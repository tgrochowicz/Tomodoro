using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tomodoro.Timer
{
    public class Timer
    {
        public Timer()
        {
            Reset();
        }

        public void Start()
        {
            backingTimer.Start();
        }
        public void Stop()
        {
            backingTimer.Stop();
        }
        public void Reset()
        {
            if(backingTimer != null)
                backingTimer.Stop();
            backingTimer = new System.Timers.Timer(MinuteInterval);
            backingTimer.Elapsed += new System.Timers.ElapsedEventHandler(minute_Elapsed);
            CurrentState = TomodoroState.Working;
            CurrentMinutesRemaining = 25;
            AlertStatusChanged();
            AlertRemainingTimeChanged();
        }

        public bool IsRunning
        {
            get
            {
                return backingTimer.Enabled;
            }
        }
        public int TimeRemaining
        {
            get
            {
                return CurrentMinutesRemaining;
            }
        }
        public TomodoroState State
        {
            get
            {
                return CurrentState;
            }
        }

        void minute_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            AdvanceClock();
        }
        private void AdvanceClock()
        {
            CurrentMinutesRemaining--;
            
            
            if(TimeRemaining == 0)
            {
                if (CurrentState == TomodoroState.Working)
                {
                    CurrentState = TomodoroState.Break;
                    CurrentMinutesRemaining = 5;
                }
                else if (CurrentState == TomodoroState.Break)
                {
                    CurrentState = TomodoroState.Done;
                    CurrentMinutesRemaining = 0;
                    backingTimer.Stop();
                }
                AlertStatusChanged();
            }
            AlertRemainingTimeChanged();
        }
        private void AlertStatusChanged()
        {
            if (StatusChanged != null)
                StatusChanged(CurrentState);
        }
        private void AlertRemainingTimeChanged()
        {
            if (RemainingTimeChanged != null)
            {
                RemainingTimeChanged(CurrentMinutesRemaining);
            }
        }
        private System.Timers.Timer backingTimer;

        private int CurrentMinutesRemaining = 25;
        private TomodoroState CurrentState;

        //60,000 milliseconds per minute
        private const int MinuteInterval = 600000;

        //work interval of 25 minutes
        private const int MinutesWorking = 25;

        //break interval of 5 minutes
        private const int MinutesBreak = 5;

        public event RemainingTimeChangedEventHandler RemainingTimeChanged;
        public event StatusChangedEventHandler StatusChanged;

        public delegate void StatusChangedEventHandler(TomodoroState State);
        public delegate void RemainingTimeChangedEventHandler(int MinutesLeft);
    }
    
    public enum TomodoroState
    {
        Working,
        Break,
        Done
    }
}
