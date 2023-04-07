﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace WorkingJournal
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Journal journal = new ();

            var emploies = new List<Employee> {
           new("Ana", "Raqviashvili"),
           new("Lasha", "Kalandadze"),
           new ("Lela", "Kvatadze"),
           new ("Shalva", "Raqviashvili"),
           new ("Giorgi", "Qituashvili"),
           new ("Giorgi", "Dafqviashvili"),
           new ("Luka", "Khijakadze"),
           new ("Vakhtang", "Kapanadze"),
           new ("Rezi", "Kakabadze"),
            new("Nani", "Gholijashvili") };

            var date = new DateTime(2023,2,1);
            var random = new Random();

            while (date < DateTime.Now)
            {
                journal.AddRecord(date, emploies.Where(x => random.Next(10) > 5).ToList());

                date = date.AddDays(1);
            }


           
            foreach (var employee in emploies)
            {
                Console.WriteLine($"{employee.Name} {employee.Surname} worked: {journal.GetTotalWorkingDays(employee)} days");
            }
        }
    }
}