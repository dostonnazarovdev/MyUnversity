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
        private Dean[] deanArray = new Dean[5];
        private int deanIndex = 0;
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
                if (subject != null && subject.Id.Equals(id))
                {
                    return subject;
                }
            }
            return null;
        }

        public Subject getSubjectByName(string name)
        {

            foreach (Subject subject in subjectArray)
            {
                if (subject != null && subject.Name.Equals(name))
                {
                    return subject;
                }
            }
            return null;
        }

        public Dean createDean(string name, string surname, int age, string birthDate, string faculty, double salary)
        {
            Dean exist = getDeanByFaculty(faculty);
            if (exist != null)
            {
                return null;
            }

            Dean dean = new Dean();
            dean.Name = name;
            dean.Surname = surname;
            dean.Age = age;
            dean.BirthDate = birthDate;
            dean.Faculty = faculty;
            dean.Salary = salary;
            deanArray[deanIndex++] = dean;
            dean.Id = generalId++;
            return dean;
        }

        public Dean getDeanById(int id)
        {
            foreach (Dean dean in deanArray)
            {
                if (dean != null && dean.Id.Equals(id))
                {
                    return dean;
                }
            }

            return null;
        }

        public Dean getDeanEmployeedDateById(int id)
        {


            return null;
        }

        public Dean getDeanByFaculty(string faculty)
        {
            foreach (Dean dean in deanArray)
            {
                if(dean!=null && dean.Faculty.Equals(faculty)){
                    return dean;
                }

            }
            return null;
        }


    }
}
