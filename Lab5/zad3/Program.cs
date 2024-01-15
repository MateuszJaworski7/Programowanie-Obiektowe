using System;

public class SomeClass
{
    private int instructionCounter = 0;

    public void CanThrowException()
    {
        instructionCounter++;
        if (new Random().Next(5) == 0)
        {
            throw new Exception($"Wyjątek wystąpił w instrukcji: {instructionCounter}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SomeClass someClassObj = new SomeClass();
        try
        {
            someClassObj.CanThrowException();
            someClassObj.CanThrowException();
            someClassObj.CanThrowException();
            someClassObj.CanThrowException();
            someClassObj.CanThrowException();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Wyjątek w instrukcji: {e.Message}");
           
        }
    }
}
