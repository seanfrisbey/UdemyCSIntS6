using System;

namespace UdemyCSIntS6
{
    public interface IActivity
    {
        void Execute();
    }

    public class ConvertVideoActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video converted.");
        }
    }
}