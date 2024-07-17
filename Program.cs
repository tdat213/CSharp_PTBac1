internal class Program
{
    private static void Main(string[] args)
    {
        double a, b;
       

        Console.WriteLine("Nhap he so a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap he so b: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nghiem cua PT la: " + GPTB1(a, b));

    }

    private static string GPTB1(double a, double b)
    {
        
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("PT vo so nghiem");
            }
            else
            {
                Console.WriteLine("PT vo nghiem");
            }

        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Nghiem cua PT la: {0}", x);
        }

            return  " ";
    }
}