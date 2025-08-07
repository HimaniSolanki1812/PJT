using System;

namespace Tanna_sir
{
    internal class Properties
    {
        private string firstname;
        private string enrollment_no;

        // 1st way: getter/setter methods
        public string getFirstname() { return firstname; }
        public void setFirstname(string value) { this.firstname = value; }

        public string getEnrollment_no() { return enrollment_no; }
        public void setEnrollment_no(string value) { this.enrollment_no = value; }

        // 2nd way: properties
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Enrollment_no
        {
            get { return enrollment_no; }
            set { enrollment_no = value; }
        }

        // Main class
        class Test
        {
            static void Main()
            {
                Properties obj = new Properties();

                // 1st way
                obj.setFirstname("Himani");
                obj.setEnrollment_no("23SOECE11079");

                Console.WriteLine("First Name: " + obj.getFirstname());
                Console.WriteLine("Enrollment No: " + obj.getEnrollment_no());

                Console.WriteLine();

                // 2nd way
                obj.Firstname = "Himani Solanki";
                obj.Enrollment_no = "23SOECE11079";

                Console.WriteLine("First Name: " + obj.Firstname);
                Console.WriteLine("Enrollment No: " + obj.Enrollment_no);
            }
        }
    }
}
