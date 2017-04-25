using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Student:Person
    {
        private string Program;
        private int Year;
        private double Fee;

        public string SProgram
        {
            get
            {
                return Program;
            }

            set
            {
                Program = value;
            }
        }

        public int SYear
        {
            get
            {
                return Year;
            }

            set
            {
                Year = value;
            }
        }

        public double SFee1
        {
            get
            {
                return Fee;
            }

            set
            {
                Fee = value;
            }
        }
        
        public Student()
        {
            Program = "";
            Year = 0;
            Fee = 0;
        }
  
        public Student (string GetProgram, int GetYear, double GetFee)
        {
            Program = GetProgram;
            Year = GetYear;
            Fee = GetFee;
        }

        public override string ToString()
        {
            return "Student[Person[Name =?, Adress= ?], Program = ?, Year = ?, fee= ?]";

        }
    }
}
