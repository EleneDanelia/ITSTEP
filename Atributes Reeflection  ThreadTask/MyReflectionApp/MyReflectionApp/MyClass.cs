using System;

[AttributeUsage(AttributeTargets.Method)]
public class ValidatePositiveAttribute : Attribute
{
    public ValidatePositiveAttribute()
    {
    }
}

public class MyClass
{
    [ValidatePositive]
    public void MyMethod(int number)
    {
        Console.WriteLine("sheikvanet dadebiTi ricxvi");
        int.TryParse(Console.ReadLine(), out number);
            if (number <= 0)
            {
                throw new ArgumentException("Parameter must be a positive integer", nameof(number));
            }
            Console.WriteLine(number);
       
    }
}

