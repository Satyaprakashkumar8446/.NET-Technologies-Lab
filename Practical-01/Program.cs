// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System;


namespace StudentAdmissionManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.AcceptDetails();
            student1.CalculateFees();
            student1.CheckAdmissionEligibility();
            student1.CalculateGrade();
            student1.CheckScholarship();
            student1.GenerateStudentID();
            student1.DisplayReceipt();

            Console.ReadKey();
        }

        class Student
        {
            // Public Data Members
            public int AdmissionNumber;
            public string StudentName;
            public int Age;
            public string Stream;
            public string Course;
            public string Branch;
            public double Percentage;
            public string Email;
            public string Mobile;

            // Private Data Members
            private double Fees;
            private bool IsAdmissionEligible;
            private double ScholarshipAmount;
            private string Grade;
            private string StudentID;
            private string PaymentStatus;
            private DateTime AdmissionDate;

            // Constructor
            public Student()
            {
                AdmissionDate = DateTime.Now;

                Console.WriteLine("==============================================");
                Console.WriteLine("      STUDENT ADMISSION MANAGEMENT SYSTEM");
                Console.WriteLine("==============================================");
                Console.WriteLine("Student Object Created Successfully.\n");
            }

            // Accept Student Details
            public void AcceptDetails()
            {
                Console.Write("Enter Admission Number : ");
                AdmissionNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Student Name : ");
                StudentName = Console.ReadLine();

                Console.Write("Enter Age : ");
                Age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Stream (Science/Commerce/Arts) : ");
                Stream = Console.ReadLine();

                Console.Write("Enter Course (B.Tech/BCA/BBA) : ");
                Course = Console.ReadLine();

                Console.Write("Enter Branch : ");
                Branch = Console.ReadLine();

                Console.Write("Enter 12th Percentage : ");
                Percentage = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Email : ");
                Email = Console.ReadLine();

                Console.Write("Enter Mobile Number : ");
                Mobile = Console.ReadLine();

                Console.Write("Payment Done? (Yes/No) : ");
                string payment = Console.ReadLine();

                if (payment.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                    PaymentStatus = "Paid";
                else
                    PaymentStatus = "Pending";
            }

            // Course Wise Fee
            public void CalculateFees()
            {
                switch (Course.ToLower())
                {
                    case "b.tech":
                    case "btech":
                        Fees = 100000;
                        break;

                    case "bca":
                        Fees = 70000;
                        break;

                    case "bba":
                        Fees = 60000;
                        break;

                    default:
                        Fees = 50000;
                        break;
                }
            }
            // Admission Eligibility
            public void CheckAdmissionEligibility()
            {
                if (Age >= 17 &&
                    Percentage >= 60 &&
                    Stream.Equals("Science", StringComparison.OrdinalIgnoreCase))
                {
                    IsAdmissionEligible = true;
                }
                else
                {
                    IsAdmissionEligible = false;
                }
            }

            // Grade
            public void CalculateGrade()
            {
                if (Percentage >= 90)
                    Grade = "A+";
                else if (Percentage >= 80)
                    Grade = "A";
                else if (Percentage >= 70)
                    Grade = "B";
                else if (Percentage >= 60)
                    Grade = "C";
                else
                    Grade = "D";
            }

            // Scholarship
            public void CheckScholarship()
            {
                if (Percentage >= 90)
                    ScholarshipAmount = Fees * 0.50;

                else if (Percentage >= 80)
                    ScholarshipAmount = Fees * 0.30;

                else if (Percentage >= 70)
                    ScholarshipAmount = Fees * 0.10;

                else
                    ScholarshipAmount = 0;
            }

            // Student ID
            public void GenerateStudentID()
            {
                StudentID = "ADM" + AdmissionNumber;
            }

            // Display Receipt
            public void DisplayReceipt()
            {
                double FinalFees = Fees - ScholarshipAmount;

                Console.WriteLine();
                Console.WriteLine("==================================================");
                Console.WriteLine("          STUDENT ADMISSION RECEIPT");
                Console.WriteLine("==================================================");

                Console.WriteLine("Student ID          : " + StudentID);
                Console.WriteLine("Admission Number    : " + AdmissionNumber);
                Console.WriteLine("Student Name        : " + StudentName);
                Console.WriteLine("Age                 : " + Age);
                Console.WriteLine("Email               : " + Email);
                Console.WriteLine("Mobile              : " + Mobile);
                Console.WriteLine("Stream              : " + Stream);
                Console.WriteLine("Course              : " + Course);
                Console.WriteLine("Branch              : " + Branch);
                Console.WriteLine("12th Percentage     : " + Percentage + "%");
                Console.WriteLine("Grade               : " + Grade);

                Console.WriteLine();

                Console.WriteLine("Admission Status    : " +
                    (IsAdmissionEligible ? "Eligible" : "Not Eligible"));

                Console.WriteLine("Course Fees         : " + Fees);
                Console.WriteLine("Scholarship Amount  : " + ScholarshipAmount);
                Console.WriteLine("Final Fees          : " + FinalFees);
                Console.WriteLine("Payment Status      : " + PaymentStatus);
                Console.WriteLine("Admission Date      : " + AdmissionDate.ToShortDateString());

                Console.WriteLine();

                if (IsAdmissionEligible)
                    Console.WriteLine("Congratulations! Your admission is successful.");
                else
                    Console.WriteLine("Sorry! You are not eligible for admission.");

                Console.WriteLine("==================================================");
            }
        }
    }
}
