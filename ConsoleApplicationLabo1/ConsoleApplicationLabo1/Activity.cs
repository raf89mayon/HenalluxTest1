using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1 {
    public class Activity {
        public string Title        {
            get;
            set;
        }

        private Boolean compulsory;
        public Boolean Compulsory       {
            get;
            set;
        }

        public string ToString()
        {
            return Title;
        }

        public Activity(String title, Boolean compulsory)        {
            Title = title;
            Compulsory = compulsory;
        }
    }
}
