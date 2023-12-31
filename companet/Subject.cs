using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnversity
{
    public class Subject
    {
        private int id;
        private string name;
        private int semester;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Semester
        {
            get
            {
                return semester;
            }

            set
            {
                semester = value;
            }
        }

    }
}
