# dojo.FizzBuzz
Over the years applying for new roles, I have asked to create a FizzBuzz project.  
Recently I was asked to do this (again) but to ensure there was testing and the code adhered to SOLID principles.
This is my attempt, when not under the pressure of a tech test to find a solution.

##### Environment
This solution is written for .net 8 with Visual Studio 2022.
Testing is done with MS-Test and FluentAssertions.

## The Simple Snippet
The following will check every number between 0 and 100 and will use if statements.
It works, but does not follow SOLID prinicples.

```
for (int i = 0; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
        Console.WriteLine("FizzBuzz");
    else if (i % 5 == 0)
        Console.WriteLine("Buzz");
    else if (i % 3 == 0)
        Console.WriteLine("Fizz");
    else
        Console.WriteLine(i);
}
```
## SOLID principles

Looking at the simple snippet, then we can create 3 rules for Fizz Buzz.  
If at somepoint in the future, there is a need to add an additional rule, such as when the number is deviseble by 7 then return "Ping Pong". We can either harddcode the requirement into the snippet or add an aditional rule.  
Thinking about the principles, then the Open Closed Priciple (OCP) is the one I will focus on. The OCP is open for extension, but closed for modification.  This also has the advantage that rules become easier to test.

![image](https://github.com/CodeTile/dojo.FizzBuzz/assets/43536260/57bb97a9-0d49-4f4f-aa0c-1b63d7c22da1)

## Rules  
A rule is a test for a condition  e.g. ```if n/3 then "Fizz"```  or a more complex rule could be  ``` if n/3 & n/5 & n/10 then "Ping Pong".  
The simplest way to do this is to parse a number for the specified number to devide by.
If the number under test is zero then the compiler will throw an error, so when you parse the number it should return false.

```
public bool Parse(int i)
{
    if (i == 0)
    {
        Result = i.ToString();
        return false;
    }
    foreach (var number in NumbersToDevideBy)
    {
        if (i % number != 0)
        {
            Result = i.ToString();
            return false;
        }
    }

    Result = FizzedWord;
    return true;
}
```  

