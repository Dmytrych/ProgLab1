using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_1
{
    class Student
    {
        public string Name { get; private set; }
        public int[] Grades { get; private set; }
        public int Avg { get; private set; }
        public bool Budget { get; private set; }
        public Student(string name, int[] grades, bool budget)
        {
            Name = name;
            Grades = grades;
            Budget = budget;
            GetAvg();
        }
        private void GetAvg()
        {
            foreach (int i in Grades)
                Avg += i;
            Avg /= Grades.Length;
        }
    }
}
