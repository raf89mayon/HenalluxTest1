using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Pupil : Person
    {
        public int Grade { get; set; }
        public List<Activity> LstActivities { get; set; }

        private char[] TabEval { get; set; }

        public Pupil (String name, int age, int grade) : base(name,age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[Parameter.getNbMax()];
        }

        public Pupil(String name, int age) : this(name, age, 1) { }

        public void AddActivity(Activity activity)
        {
            if (LstActivities.Count() < Parameter.getNbMax())
                LstActivities.Add(activity);
            //  else  System.Console.Write("exces nb activites");
        }

        public override string ToString()
        {
            string ch = base.ToString();
            int cptActivities = LstActivities.Count();
            if (cptActivities == 0)
            {
                ch += "n'a pas encore choisi d'activité";
            }
            else
            {
                ch += " inscrit dans :";
                int i = 0;
                foreach (Activity activity in LstActivities)
                {
                    ch += "\n\t- " + activity.ToString() + " evaluation : " + TabEval[i];
                    i++;
                }
            }
            return ch;
        }

        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            if (title != null)
            {
                int cpt = 0;
                foreach (Activity activity in LstActivities)
                {
                    if (activity.ToString() == title)
                    {
                        TabEval[cpt] = evaluation;
                        break;
                    }
                    else
                    {
                        cpt++;
                    }
                }
            }
        }
    }
}
