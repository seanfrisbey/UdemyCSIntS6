using System.Collections.Generic;
using System.ComponentModel;

namespace UdemyCSIntS6
{
    public class Workflow
    {
        private readonly IList<IActivity> _activity;

        public Workflow()
        {
            _activity = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            _activity.Add(activity);
        }

        public void Run()
        {
            foreach (var activity in _activity)
            {
                activity.Execute();
            }
        }
    }
}