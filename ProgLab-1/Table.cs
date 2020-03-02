using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_1
{
    class Table
    {
        public List<Student> Students { get; private set; }
        public Table()
        {
            Students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void QuickSort()
        {
            Student markStudent = Students[Students.Count];
            for(int j = 0; j < Students.Count; j++)
            {
                for (int i = 0; i < Students.Count; i++)
                {
                    if (Students[i].Avg < Students[i + 1].Avg)
                        Swap(i, i + 1);
                }
            }
        }
        private void Swap(int studIndex1, int studIndex2)
        {
            Student temp = Students[studIndex1];
            Students[studIndex1] = Students[studIndex2];
            Students[studIndex2] = temp;
        }
        public void PrintTable()
        {
            int count = 0;
            foreach(Student student in Students)
            {
                count++;
                Console.WriteLine(count + ": " + student.Avg);
            }
        }
    }
}
