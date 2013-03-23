Student
=======
22.Common Type System

Tasks 1 To 3

Task 1:
Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities
 and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() 
 and operators == and !=.

Task 2:
Add implementations of the ICloneable interface. 
The Clone() method should deeply copy all object's fields into a new object of type Student.

Task 3:
Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
and by social security number (as second criteria, in increasing order).
