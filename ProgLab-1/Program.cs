using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace ProgLab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Table budgetTable;
            string[] files;
            string path;
            budgetTable = new Table();

            path = CsvIO.GetPath();
            files = CsvIO.GetFiles(path);
            CsvIO.ParseToTable(path, files, budgetTable);
          
            
        }
    }
    static class CsvWork
    {
        
    }
    class ManageTables
    {
            
    }
}
