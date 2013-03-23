using System;
using System.Text;

namespace Student
{
    class Student : ICloneable, IComparable<Student>
    {
        public enum University {Sofia_University, UNSS, Technical_University}
        public enum Faculty { Mathematics_and_informatics, Economics_and_Management }
        public enum Specialty {Business_Administration, Informatics, Economics, Management }     

        //Fields
        private string firstName;
        private string middleName;      
        private string lastName;
        private ulong ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private int course;
        private University university;
        private Faculty faculty;
        private Specialty specialty;        

        //Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public ulong SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public string PermanentAddress
        {
            get { return permanentAddress; }
            set { permanentAddress = value; }
        }

        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }

        public string eMail
        {
            get { return email; }
            set { email = value; }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public University UniversityProperty
        {
            get { return university; }
            set { university = value; }
        }

        public Faculty FacultyProperty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public Specialty SpecialtyProperty
        {
            get { return specialty; }
            set { specialty = value; }
        }
        
        //Constructor
        public Student(string firstName, string middleName, string lastName, ulong ssn, string permanentaddress, string mobilePhone, string email, int course, University university, Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permanentaddress;
            this.MobilePhone = mobilePhone;
            this.eMail = email;
            this.Course = course;
            this.UniversityProperty = university;
            this.FacultyProperty = faculty;
            this.SpecialtyProperty = specialty;      
        }

        public override bool Equals(object obj)
        {
            if (this.SSN == (obj as Student).SSN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Student studentOne, Student studentTwo)
        {
            return Student.Equals(studentOne, studentTwo);
        }

        public static bool operator !=(Student studentOne, Student studentTwo)
        {
            return !(Student.Equals(studentOne, studentTwo));
        }

        public override string ToString()
        {
            StringBuilder studentBuilder = new StringBuilder();
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("Name: {0} {1} {2}", FirstName, MiddleName, LastName);
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("SSN: {0}", SSN);
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("Permanent address: {0}", PermanentAddress);
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("Mobile Phone: {0}", MobilePhone);
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("e-mail: {0}", eMail);
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("University: {0}", UniversityProperty);
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("Faculty: {0}", FacultyProperty);
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("Specialty: {0}", SpecialtyProperty);
            studentBuilder.AppendLine();
            studentBuilder.AppendFormat("Course: {0}", Course);
            studentBuilder.AppendLine();
            studentBuilder.AppendLine(new string('-', 50));

            return studentBuilder.ToString();
        }

        public override int GetHashCode()
        {
            return SSN.GetHashCode() ^ FirstName.GetHashCode() ^ LastName.GetHashCode();
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.MobilePhone, this.eMail, this.Course, this.UniversityProperty, this.FacultyProperty, this.SpecialtyProperty) as object;
        }

        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return (this.FirstName.CompareTo(student.FirstName));
            }
            if (this.MiddleName != student.MiddleName)
            {
                return (this.MiddleName.CompareTo(student.MiddleName));
            }
            if (this.LastName != student.LastName)
            {
                return (this.LastName.CompareTo(student.LastName));
            }
            else
            {
                return ssn.CompareTo(student.ssn);
            }
        }
    }
}
