using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TelefonnaCentrala
{
    public abstract class Danni : IPhoneNumber , TelNomer 
    {
        private int age;
        private string address;
        private string profession;
        
        


        public int Age
        {
            get { return age; }
            set { age = value; }

        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public Danni(int age,string address,string profession,int number,string ownername) :base(number,ownername)
        {
            this.Age = age;
            this.Address = address;
            this.Profession = profession;
        }

        public abstract void ValidateData();

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Telefonen nomer: {Number}");
            Console.WriteLine($"Ime na sobstvenik: {OwnerName}");
            Console.WriteLine($"Vuzrast: {Age}");
            Console.WriteLine($"Adres: {Address}");
            Console.WriteLine($"Profesiq: {Profession}");
        }
    }
}
