﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonnaCentrala
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Danni> Danni = new List<Danni>();
            Console.WriteLine("Vuvedete broq na telefonnite nomera: ");
            int p = int.Parse(Console.ReadLine());
            for (int i = 0; i < p; i++)
            {
                Console.Write($"Vuvedete telefonen nomer : ");
                int number = int.Parse(Console.ReadLine());
                Console.Write($"Ime na sobstvenik: ");
                string ownerName = Console.ReadLine();
                Console.Write($"Vuzrast: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write($"Adres: ");
                string address = Console.ReadLine();
                Console.Write($"Profesiq: ");
                string profession = Console.ReadLine();

                Danni data = new TelNomer();
                data.Number = number;
                data.OwnerName = ownerName;
                data.Age = age;
                data.Address = address;
                data.Profession = profession;

                data.Add(Danni);
            }
 
        }
    }
}
