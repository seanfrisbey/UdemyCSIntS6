using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCSIntS6
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow workflow = new Workflow();

            workflow.AddActivity(new ImportVideoActivity());
            workflow.AddActivity(new ConvertVideoActivity());
            workflow.AddActivity(new TransferVideoActivity());

            workflow.Run();
        }
    }
}
