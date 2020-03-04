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
        public CsvIO(string dirPath)
        {
            files = Directory.GetFiles(dirPath, "*.csv");
        }
        public void ParseToTable(Table table)
        {
            int[] grades;
            string[] line;
            StreamReader reader;
            foreach (string fileName in files)
            {
                reader = new StreamReader(fileName, Encoding.GetEncoding("KOI8"),false);
                int studentCount = Convert.ToInt32(reader.ReadLine());
                for (int i = 0; i < studentCount; i++)
                {
                    line = reader.ReadLine().Split(',');
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
        public void SaveTable(Table table, string directoryPath)
        {
            StreamWriter writer = new StreamWriter(directoryPath + "\\Saves.txt", false, Encoding.GetEncoding("KOI8"));
            foreach (Student student in table.Students)
            {
                writer.WriteLine($"{student.Name};{student.Avg}");
            }
            writer.Flush();
            writer.Close();
        }
    }
}
