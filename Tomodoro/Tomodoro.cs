using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tomodoro
{
    public partial class Tomodoro : Form
    {
        Timer.Timer tmrPomodoro;
        
        public Tomodoro()
        {
            InitializeComponent();
            tmrPomodoro = new Timer.Timer();
            tmrPomodoro.RemainingTimeChanged += new Timer.Timer.RemainingTimeChangedEventHandler(tmrPomodoro_RemainingTimeChanged);
            tmrPomodoro.StatusChanged += new Timer.Timer.StatusChangedEventHandler(tmrPomodoro_StatusChanged);

        }

        #region Timer
        void tmrPomodoro_StatusChanged(Timer.TomodoroState State)
        {
            SetText(lblStatus, State.ToString().ToUpper());
            if (State == Timer.TomodoroState.Done)
                SetStartable();

            if (State == Timer.TomodoroState.Working)
                notificationIcon.ShowBalloonTip(30000, "Tomodoro Alert", "Time to start working!", ToolTipIcon.None);
            else if (State == Timer.TomodoroState.Break)
                notificationIcon.ShowBalloonTip(30000, "Tomodoro Alert", "Time for a break!", ToolTipIcon.None);
            else if (State == Timer.TomodoroState.Done)
                notificationIcon.ShowBalloonTip(30000, "Tomodoro Alert", "Tomodoro complete!", ToolTipIcon.None);
        }
        void tmrPomodoro_RemainingTimeChanged(int MinutesLeft)
        {
            SetText(lblTimeRemaining, String.Format("{0} Minutes Left", MinutesLeft));
        }

        /// <summary>
        /// Provides a threadsafe way to update a control's text
        /// </summary>
        /// <param name="c"></param>
        /// <param name="Text"></param>
        void SetText(Control c, string Text)
        {
            if (c.InvokeRequired)
            {
                SetTextCallback callback = new SetTextCallback(SetText);
                this.Invoke(callback, new object[] { c, Text });
            }
            else
            {
                c.Text = Text;
            }
        }
        delegate void SetTextCallback(Control c, string text);

        /// <summary>
        /// Provides a threadsafe way to update a control's enabled status
        /// </summary>
        /// <param name="c"></param>
        /// <param name="Enabled"></param>
        void SetEnabled(Control c, bool Enabled)
        {
            if (c.InvokeRequired)
            {
                SetEnabledCallback callback = new SetEnabledCallback(SetEnabled);
                this.Invoke(callback, new object[] { c, Enabled });
            }
            else
            {
                c.Enabled = Enabled;
            }
        }
        delegate void SetEnabledCallback(Control c, bool Enabled);

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!tmrPomodoro.IsRunning)
            {
                if (tmrPomodoro.State == Timer.TomodoroState.Done)
                    tmrPomodoro.Reset();

                tmrPomodoro.Start();
                SetStoppable();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            tmrPomodoro.Reset();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrPomodoro.Stop();
            SetStartable();
        }

        private void SetStartable()
        {
            SetEnabled(btnReset, true);
            SetEnabled(btnStart, true);
            SetEnabled(btnStop, false);
        }
        private void SetStoppable()
        {
            SetEnabled(btnReset, false);
            SetEnabled(btnStart, false);
            SetEnabled(btnStop, true);
        }

        #endregion Timer

        #region Repository
        private void PopulateUI(DateTime date)
        {
            CurrentWorkday = CurrentRepository.GetWorkday(date.Date);
            
            //Can't bind to winforms checkedlistbox
            foreach (var todo in CurrentWorkday.Goals)
            {
                clbGoals.Items.Add(todo, todo.Completed);
            }
            foreach (var workitem in CurrentWorkday.Tomodori)
            {
                clbTomodori.Items.Add(workitem, workitem.Completed);
            }
        }
        private void Save()
        {
            CurrentWorkday.Goals.Clear();
            CurrentWorkday.Tomodori.Clear();

            foreach (object item in clbGoals.Items)
            {
                CurrentWorkday.Goals.Add((Data.Goal)item);
            }
            foreach (object item in clbTomodori.Items)
            {
                CurrentWorkday.Tomodori.Add((Data.Tomodori)item);
            }

            Data.TomodoriRepository.WriteToFile(RepositoryPath, CurrentRepository);
        }

        private void ClearTomodoriText()
        {
            txtNotes.Clear();
            txtTitle.Clear();
        }
        private void ClearGoalText()
        {
            txtGoal.Clear();
        }
        private Data.TomodoriRepository CurrentRepository;
        private Data.Workday CurrentWorkday;
        private string RepositoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Tomodoro/Tomodoro.xml";
        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            if (txtGoal.Text.Length > 0)
            {
                Data.Goal Goal = new Data.Goal();
                Goal.Completed = false;
                Goal.GoalDescription = txtGoal.Text;
                clbGoals.Items.Add(Goal);
                ClearGoalText();
            }
        }
        private void clbGoals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbGoals.SelectedItem != null)
                txtGoal.Text = clbGoals.SelectedItem.ToString();
            else
                ClearGoalText();
        }
        private void btnUpdateGoal_Click(object sender, EventArgs e)
        {
            if (txtGoal.Text.Length > 0)
            {
                if (clbGoals.SelectedItem != null)
                {
                    var goal = (Data.Goal)clbGoals.SelectedItem;
                    goal.GoalDescription = txtGoal.Text;
                }
            }
        }
        private void clbGoals_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var goal = (Data.Goal)clbGoals.Items[e.Index];
            goal.Completed = e.NewValue == CheckState.Checked;
        }
        private void btnDeleteGoal_Click(object sender, EventArgs e)
        {
            if (clbGoals.SelectedItem != null)
                clbGoals.Items.Remove(clbGoals.SelectedItem);
            ClearGoalText();
        }

        private void btnAddTomodori_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length > 0)
            {
                Data.Tomodori tomodori = new Data.Tomodori();
                tomodori.Completed = false;
                tomodori.Topic = txtTitle.Text;
                tomodori.Notes = txtNotes.Text;
                clbTomodori.Items.Add(tomodori);
                txtTitle.Clear();
                txtNotes.Clear();
            }
            ClearTomodoriText();
        }
        private void clbTomodori_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var tomodori = (Data.Tomodori)clbTomodori.Items[e.Index];
            tomodori.Completed = e.NewValue == CheckState.Checked;
        }
        private void clbTomodori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbTomodori.SelectedItem != null)
            {
                var tomodori = (Data.Tomodori)clbTomodori.SelectedItem;
                txtTitle.Text = tomodori.Topic;
                txtNotes.Lines = tomodori.Notes.Split('\n');
            }
            else
                ClearTomodoriText();
        }
        private void btnUpdateTomodori_Click(object sender, EventArgs e)
        {
            if (clbTomodori.SelectedItem != null)
            {
                var tomodori = (Data.Tomodori)clbTomodori.SelectedItem;
                tomodori.Topic = txtTitle.Text;
                tomodori.Notes = txtNotes.Text;
            }
        }
        private void btnDeleteTomodori_Click(object sender, EventArgs e)
        {
            if (clbTomodori.SelectedItem != null)
                clbTomodori.Items.Remove(clbTomodori.SelectedItem);
            ClearTomodoriText();
        }
        private void btnClearTomodori_Click(object sender, EventArgs e)
        {
            ClearTomodoriText();
            clbTomodori.SelectedIndex = -1;
        }
        private void btnClearGoal_Click(object sender, EventArgs e)
        {
            ClearGoalText();
            clbGoals.SelectedIndex = -1;
        }

        private void Tomodoro_Load(object sender, EventArgs e)
        {
            CurrentRepository = Data.TomodoriRepository.LoadFromFile(RepositoryPath);
            PopulateUI(DateTime.Today);
        }
        private void Tomodoro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        #endregion Repository

    }
}
