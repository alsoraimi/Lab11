using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Staff:Person
    {
        private string School;
        private double Pay;

        public string _School
        {
            get
            {
                return School;
            }

            set
            {
                School = value;
            }
        }

        public double SPay
        {
            get
            {
                return Pay;
            }

            set
            {
                Pay = value;
            }
        }

        public Staff ()
        {
            School = "";
            Pay = 0;
        }

        public Staff (string GetSchool, double GetPay)
        {
            School = GetSchool;
            Pay = GetPay;

        }

        public override string ToString()
        {
            return $"Staff[Student[Person[Name ={PName}, Adress= {PAdress}], school = {School}, pay = {Pay}]";

        }
    }
}
