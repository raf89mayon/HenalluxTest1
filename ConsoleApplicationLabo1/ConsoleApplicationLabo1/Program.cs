using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pup1 = new Pupil("Marcel", 12);
            Activity act1 = new Activity("Natation", false);
            Activity act2 = new Activity("Football", false);
            Activity act3 = new Activity("Tennis", false);
            Activity act4 = new Activity("Rugby", false);

            pup1.AddActivity(act1);
            pup1.AddActivity(act2);
            pup1.AddActivity(act3);
            pup1.AddActivity(act1);
            pup1.AddActivity(act2);
            pup1.AddActivity(act3);
            pup1.AddActivity(act1);
            pup1.AddActivity(act2);
            pup1.AddActivity(act3);
            pup1.AddActivity(act1);
            pup1.AddActivity(act4);

            pup1.AddEvaluation("Tennis", 'R');
            pup1.AddEvaluation("Handball");
            pup1.AddEvaluation("Rugby", 'T');

            System.Console.Write(pup1);
            System.Console.Write("\n");
            System.Console.Read();
        }
    }
}
