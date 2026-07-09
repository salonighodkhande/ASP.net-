using System;

class Conditional
{
    public static void Run()
    {
        int marks = 30;

        if (marks >= 90)
        {
            Console.WriteLine("Grade : A");
        }

        else if ( marks >=70)
        {
              Console.WriteLine("Grade : B");
        }

        else if ( marks >=50)
        {
              Console.WriteLine("Grade : C");
        }

        else if ( marks >=30)
        {
          Console.WriteLine("Grade : F");
        }

        else
        {
          Console.WriteLine("Failed");
          }

    }
}