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
            Student markStudent = Students[Students.Count-1];
            for(int j = 0; j < Students.Count; j++)
            {
                for (int i = 1; i < Students.Count; i++)
                {
                    if (Students[i-1].Avg < Students[i].Avg)
                        Swap(i-1, i);
                }
            }
        }
        private void Swap(int studIndex1, int studIndex2)
        {
            Student temp = Students[studIndex1];
            Students[studIndex1] = Students[studIndex2];
            Students[studIndex2] = temp;
        }
        public void ShowMinMark()
        {
           Console.WriteLine(Students[Students.Count - 1].Avg);
        }
        public void DekanatPublishedRating() // Откидывает из таблицы всех лохов-нестипендиантов, как мы :)
        {
            int stipendiantCount = Convert.ToInt32(Math.Floor(Convert.ToDouble(Students.Count) * 0.4));
            Students.RemoveRange(stipendiantCount,Students.Count-stipendiantCount);
        }
    }
}
