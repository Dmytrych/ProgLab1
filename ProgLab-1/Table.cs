﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab_1
{
    class Table
    {
        public List<Student> Students { get; private set; }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}