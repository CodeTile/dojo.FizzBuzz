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
