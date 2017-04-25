using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Person
    {
        private string Name;
        private string Adress;


        public string PName
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }

        }

        public string PAdress
        {
            get
            {
                return Adress;
            }

            set
            {
                Adress = value;
            }
        }

        public Person ()
        {
            Name = "";
            Adress = "";
        }

        public Person (string GetName, string GetAdress)
        {
            Name = GetName;
            Adress = GetAdress;
        }

        public override string ToString()
        {
            return $"Person[Name ={Name}, Adress= {Adress}]";    //remember this shit its important


        }





    }
}
