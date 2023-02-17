using System;
using System.Reflection.Metadata.Ecma335;

namespace uppgiftett_Enivå
{
    class program
    {
        static int celsiusTofahrenheit(int c)
        {
            int f = ((c * 9) / 5) + 32;
            return f;
        }
        static double FarenheitTocelsius(double k)
        {
            
            return (k-32/1.8);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("skriv 1 eller 2 beror på vilken omvandling du vill göra");
            Console.WriteLine("1.Omvandla från celsius till fahrenheit");
            Console.WriteLine("2.Omvandla från fahrenheit till celsius");
            string val=Console.ReadLine();

            switch (val)
            {
                case "1":
                    {
                        Console.WriteLine("skriv in grader i celsius");
                        int celsius = Convert.ToInt32(Console.ReadLine());
                        int fahrenheit = celsiusTofahrenheit(celsius);
                        Console.WriteLine("Det blir " + fahrenheit + " grader i fahrenheit.");
                    }

               break;
                case "2":
                    {
                        Console.WriteLine("skriv in grader i fahrenheit");
                        double k = Convert.ToDouble(Console.ReadLine());
                        double celsius = FarenheitTocelsius(k);
                        Console.WriteLine("Det blir " + celsius + " grader i celsius.");

                    }
                    break;
            }



        }
     
    }
}
