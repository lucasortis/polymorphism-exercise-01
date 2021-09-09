﻿using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioPropostoPolimorfismoUm.Entities;


namespace ExercicioPropostoPolimorfismoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee number #{i} data:");

                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                } 
                else if (outsourced == 'n') 
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                    Console.WriteLine("Invalid caracter");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
