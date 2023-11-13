internal class Sumator
{
    private double[] Liczby;

    public Sumator(double[] liczby)
    {
        Liczby = liczby;
    }

    public double Suma()
    {
        double suma = Liczby.Sum();
        return suma;
    }

    public double SumDziel2()
    {
        double sumaPodziel = 0;
        foreach (var item in Liczby)
        {
            if (item % 2 == 0)
            {
                sumaPodziel += item;
            }
        }
        return sumaPodziel;
    }

    public int IleElementów()
    {
        int elementyIlosc = Liczby.Length;
        return elementyIlosc;
    }

    public void WypiszElem()
    {
        foreach (var item in Liczby)
        {
            Console.WriteLine(item);
        }
    }

    public void WypiszElem(int lowindex, int highindex)
    {
        if (lowindex < 0)
        {
            lowindex = 0;
        }
        if (highindex >= Liczby.Length)
        {
            highindex = Liczby.Length - 1;
        }
        for (int i = lowindex; i <= highindex; i++)
        {
            Console.WriteLine(Liczby[i]);
        }
    }
}