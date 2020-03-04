using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgLab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Table budgetTable;
            string path;
            budgetTable = new Table();
            Console.Write("Plz, enter directory path:");
            path = Console.ReadLine();
            CsvIO csvReader = new CsvIO(path);
            csvReader.ParseToTable(budgetTable);
            budgetTable.PrintTable();
            Console.WriteLine("Лохі");
            Console.Read();
        }
    }
    static class CsvWork
    {
        
    }
    class ManageTables
    {
            
    }
}
