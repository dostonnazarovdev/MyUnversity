using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnversity
{
    public class UnveristyManger
    {
        private string name;
        private Subject[] subjectArray = new Subject[5];
        private int subIndex = 0;
        private int generalId = 1;

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

        public string Address { get; set; }

        public Subject createSubject(string name, int semester)
        {

            Subject subject = new Subject();
            subject.Name = name;
            subject.Semester = semester;
            subjectArray[subIndex++] = subject;
            subject.Id = generalId++;
            return subject;
        }

        public Subject getSubjectId(int id)
        {
            foreach (Subject subject in subjectArray)
            {
                if (subject!=null && subject.Id.Equals(id))
                {
                    return subject;
                }
            }
            return null;
        }
    }
}
