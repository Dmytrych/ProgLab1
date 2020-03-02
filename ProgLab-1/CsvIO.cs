using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgLab_1
{
    static class CsvIO
    {
        public static string GetPath()
        {
            Console.WriteLine("Введите путь к папке с входными данными\n");
            string path = Console.ReadLine();
            return path;
        }
        public static string[] GetFiles(string path)
        {
            string[] files = Directory.GetFiles(path, ".csv");
            return files;
        }

        public static void ParseToTable(string path, string[] files, Table budgetTable){

            foreach (string fileName in files)
            {
                StreamReader reader = new StreamReader(path + "/" + fileName);
                int num = Convert.ToInt32(reader.ReadLine());
                for (int i = 0; i<num; i++)
                {
                    string[] tempStudent = reader.ReadLine().Split(new char[',']);
                    int[] grades = new int[5];
                    for (int k = 0; k<grades.Length; k++)
                    {
                        grades[k] = Convert.ToInt32(tempStudent[i + 1]);
                    }
                    bool contract = Convert.ToBoolean(tempStudent[6]);
                    Student temp = new Student(tempStudent[0], grades, contract);
                    if (!contract)
                    {
                        budgetTable.AddStudent(temp);
                    }
                }
            }
            }
    }
}
