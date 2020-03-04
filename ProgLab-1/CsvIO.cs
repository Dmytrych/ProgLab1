using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgLab_1
{
    class CsvIO
    {
        public string[] files { get; private set; }
        private string dirPath;
        public CsvIO(string dirPath)
        {
            this.dirPath = dirPath;
            files = Directory.GetFiles(dirPath, "*.csv");
        }
        public void ParseToTable(Table table)
        {
            int[] grades;
            string[] line;
            StreamReader reader;
            foreach (string fileName in files)
            {
                reader = new StreamReader(fileName);
                int studentCount = Convert.ToInt32(reader.ReadLine());
                for (int i = 0; i < studentCount; i++)
                {
                    line = reader.ReadLine().Split(';');
                    grades = new int[5];
                    for (int k = 0; k < grades.Length; k++)
                    {
                        grades[k] = Convert.ToInt32(line[k + 1]);
                    }
                    bool contract = Convert.ToBoolean(line[6]);
                    if (!contract)
                    {
                        table.AddStudent(new Student(line[0], grades, contract));
                    }
                }
                reader.Close();
            }
        }
        public void SaveTable(Table table, string dirPath)
        {
            StreamWriter writer = new StreamWriter(dirPath);
            foreach (Student student in table.Students)
            {
                writer.WriteLine($"{student.Name};{student.Avg}");
            }
            writer.Flush();
            writer.Close();
        }


    }
}
