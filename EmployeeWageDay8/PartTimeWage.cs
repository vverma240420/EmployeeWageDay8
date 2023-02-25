﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDay8
{
    internal class PartTimeWage
    {
        public static void PartTime()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;

            Console.WriteLine("Welcome to EmployeeWage Computation");

            //UC3- PartTimeWage
            Random random = new Random();
            int empAttendence = random.Next(0, 3); //0 or 1 or 2 it will generate
            if (empAttendence == FULL_TIME)
            {
                Console.WriteLine("Full time employee is Present");
                empHrs = 8;
            }
            else if (empAttendence == PART_TIME)
            {
                Console.WriteLine("Part time employee is present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                //empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            //Console.WriteLine("Employee wage:"+empWage);  old way
            Console.WriteLine("Employee Wage:{0}", empWage);  //new way
            Console.ReadLine();
        }
    }
}
