using System;

class CustomException1 : Exception
{
    public CustomException1(string message) : base(message) { }
}

class CustomException2 : Exception
{
    public CustomException2(string message) : base(message) { }
}

class CustomException3 : Exception
{
    public CustomException3(string message) : base(message) { }
}

class Program
{
    static void RzucLosowyWyjatek()
    {
        Random random = new Random();
        int losowaLiczba = random.Next(1, 4);

        switch (losowaLiczba)
        {
            case 1:
                throw new CustomException1("To jest CustomException1.");
            case 2:
                throw new CustomException2("To jest CustomException2.");
            case 3:
                throw new CustomException3("To jest CustomException3.");
        }
    }

    static void Main()
    {
        try
        {
            RzucLosowyWyjatek();
        }
        catch (CustomException1 ex1)
        {
            Console.WriteLine("Złapany wyjątek: CustomException1");
            Console.WriteLine(ex1.Message);
        }
        catch (CustomException2 ex2)
        {
            Console.WriteLine("Złapany wyjątek: CustomException2");
            Console.WriteLine(ex2.Message);
        }
        catch (CustomException3 ex3)
        {
            Console.WriteLine("Złapany wyjątek: CustomException3");
            Console.WriteLine(ex3.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Złapany inny wyjątek:");
            Console.WriteLine(ex.Message);
        }
    }
}
