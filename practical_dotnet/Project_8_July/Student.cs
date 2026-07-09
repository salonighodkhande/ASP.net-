//class - it is a logical entity, defines the properties(data) and fuctions that object will have 
// store values of similar data 
// eg : car , dog, electronics 

using System;

class Student
{
    public int rollno;
    public string? name;
    public string? coaching;
    public long dob;
    public string? branch;
    public char gender;
    public float height;

    public void display()
    {
        Console.WriteLine("Roll No : " + rollno);
        Console.WriteLine("Name    : " + name);
        Console.WriteLine("Coaching: " + coaching);
        Console.WriteLine("DOB     : " + dob);
        Console.WriteLine("Branch  : " + branch);
        Console.WriteLine("Gender  : " + gender);
        Console.WriteLine("Height  : " + height);
    }
}