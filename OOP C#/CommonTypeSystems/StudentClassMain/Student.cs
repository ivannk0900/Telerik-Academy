using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassMain
{
    class Student : ICloneable,IComparable<Student>
    {
        public enum Universityies
        {
            SofiaUniversity,
            UNWE,
            TechnicalUniversity
        };
        public enum Specialities
        {
            SowtwareEngineering,
            ComputerScience,
            Informatics,

        };
        public enum Faculties
        {
            FacultyOfPharmacy,
            FacultyOfMathematicsAndInformatics,
            FacultyOfEconomics

        };

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong SSN { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public ulong PhoneNumber { get; set; }
        public short Course { get; set; }
        public Universityies University { get; set; }
        public Faculties Faculty { get; set; }
        public Specialities Speciality { get; set; }


        public Student(string firstName,string middleName,string lastName,ulong SSN,string address,string email,ulong phoneNumber,short course,Universityies university,Faculties faculty,Specialities speciality)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.Address = address;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Course = course;
            this.University = university;
            this.Speciality = speciality;
            this.Faculty = faculty;
        }



        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if(student==null)
            {
                return false;
            }

            // Compare the reference type member fields
            if(!Object.Equals(this.FirstName,student.FirstName))
            {
                return false;
            }
            if(!Object.Equals(this.MiddleName,student.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            if (!Object.Equals(this.Address, student.Address))
            {
                return false;
            }
            if (!Object.Equals(this.Email, student.Email))
            {
                return false;
            }
            // Compare the value type fields
            if(this.PhoneNumber!=student.PhoneNumber)
            {
                return false;
            }
            if(this.Course!=student.Course)
            {
                return false;
            }
            if(this.SSN!=student.SSN)
            {
                return false;
            }
            if(this.University!=student.University)
            {
                return false;
            }
            if(this.Faculty!=student.Faculty)
            {
                return false;
            }
            if(this.Speciality!=student.Speciality)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode();
        }

        public static bool operator == (Student student1,Student student2)
        {
            return Student.Equals(student1, student2);
        }
        public static bool operator != (Student student1,Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} University: {3} Faculty: {4} Speciality: {5} Course: {6} SSN: {7} Address: {8} Email: {9} Phone Number: {10}", this.FirstName, this.MiddleName, this.LastName, this.University, this.Faculty, this.Speciality, this.Course, this.SSN, this.Address, this.Email, this.PhoneNumber);
        }

        public object Clone()
        {
             Student cloned = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.Email, this.PhoneNumber, this.Course, this.University, this.Faculty, this.Speciality);

           return cloned;
        }



        public int CompareTo(Student other)
        {
            if(this.FirstName.CompareTo(other.FirstName)==0)
            {
                if(this.SSN==other.SSN)
                {
                    return 0;
                }
               
            }

            return this.FirstName.CompareTo(other.FirstName);
            
        }
    }
}
