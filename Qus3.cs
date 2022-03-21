using System;
using System.Collections.Generic;
using System.Text;

namespace LabFinalProblemPractice
{
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public void Validate()
        {
            if (Street != "" && City != "" && State != "" && PostalCode != "" && Country != "") 
                Console.WriteLine("Valid address");
        }
    }
    class Person : Address
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public void PurchaseParkingPass()
        {
            Console.WriteLine(Name + " just purchase a parking pass");
        }
    }

    class Student:Person
    {
        public int StudentNumber { get; set; }
        public decimal AverageMark { get; set; }

        public void EligibleToEnroll()
        {
            if (AverageMark > 70) Console.WriteLine(Name + " is eligible to enroll");
            else Console.WriteLine(Name + " is not eligible to enroll");
        }
    }

    class Professor:Person
    {
        public int Salary { get; set; }
    }
    class Qus3
    {
        public static void StudentTest()
        {
            Student std = new Student();
            std.Name = "Maruf";
            std.AverageMark = 80;
            std.EligibleToEnroll();
        }

        public static void ProfessorTest()
        {
            Professor pro = new Professor();
            pro.Name = "Shakil Ahmed";
            pro.Salary = 99999999;
            pro.PurchaseParkingPass();
        }

    }
}
