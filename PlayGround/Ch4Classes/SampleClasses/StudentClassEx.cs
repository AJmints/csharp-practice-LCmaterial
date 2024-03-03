using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{

    private static int nextStudentId = 1;
    public string Name { get; set; }
    public int StudentId { get; set; }
    public int NumberOfCredits { get; set; }
    public double Gpa { get; set; }

    public Student(string name, int studentId,
            int numberOfCredits, double gpa)
    {
        Name = name;
        StudentId = studentId;
        NumberOfCredits = numberOfCredits;
        Gpa = gpa;
    }

    public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

    public Student(string name)
        : this(name, nextStudentId)
    {
        nextStudentId++;
    }

    public string StudentInfo()
    {
        return Name + " has a GPA of: " + Gpa;
    }

        
}
