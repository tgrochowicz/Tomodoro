using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tomodoro.Data
{
    public class Workday
    {
        //Date
        public DateTime Date
        { get; set; }

        //Goals
        private List<Goal> _Goals = new List<Goal>();
        public List<Goal> Goals
        {
            get
            {
                return _Goals;
            }
            set
            {
                _Goals = value;
            }
        }

        //Tomodori
        private List<Tomodori> _Tomodori = new List<Tomodori>();
        public List<Tomodori> Tomodori
        {
            get
            {
                return _Tomodori;
            }
            set
            {
                _Tomodori = value;
            }
        }
    }
    
    public class Goal
    {
        public string GoalDescription
        { get; set; }
        public bool Completed
        { get; set; }

        public override string ToString()
        {
            return GoalDescription;
        }
    }

    public class Tomodori
    {
        public string Topic
        { get; set; }
        public string Notes
        { get; set; }
        public bool Completed
        { get; set; }

        public override string ToString()
        {
            return Topic;
        }
    }


}
