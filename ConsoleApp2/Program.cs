using System;

namespace DOTNET_T1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Welcome to Billing Site\n");
            int unit = 0; int PrevMonth = 0; int cmonth = 0;
            bool StartFlag = true;
            bool errorflag = false;
            do
            {

                Console.WriteLine("Pls Provide PreviousMonthReadings");


                try
                {
                    PrevMonth = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    try
                    {
                        Console.WriteLine("Pls Provide Integer Value For PreviousMonthReadings");
                        PrevMonth = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Pls Provide Correct Integer PreviousMonthReadings ,you entered it wrong twice ");
                        errorflag = true;
                        continue;


                    }
                }


                Console.WriteLine("Pls Provide PresentMonthReadings ");



                try
                {
                    cmonth = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    try
                    {
                        Console.WriteLine("Pls Provide Integer Value For PresentMonthReadings");
                        cmonth = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Pls Provide Correct Integer PresentMonthReadings ,you entered it wrong twice ");
                        errorflag = true;
                        continue;

                    }
                }
                unit = cmonth - PrevMonth;


                StartFlag = unit < 0;
                

            } while (StartFlag);
            if (!errorflag)
            {
                Console.WriteLine($" Your Bill Amount For {unit} is {CheckReadingAmount(PrevMonth, cmonth)}");
            }

        }
        private static int CheckReadingAmount(int PrevMonth, int cmonth)
        {
            int Amount = 0;

            int unit = PrevMonth - cmonth;
            switch (unit)
            {
                case int when unit <= 100:
                    return Amount = 100;
                    break;

                case int when (unit <= 200 && unit > 100):
                    return Amount = 100 + (unit - 100) * 5;
                    break;

                case int when (unit <= 300 && unit > 200):
                    return Amount = 100 + (unit - 100) * 5;
                    break;

                case int when (unit <= 300 && unit > 200):
                    return Amount = 100 + (unit - 200) * 6 + 500;
                    break;

                case int when (unit <= 400 && unit > 300):
                    return Amount = 100 + (unit - 300) * 7 + 500 + 600;
                    break;

                case int when (unit > 400):
                    return Amount = 100 + (unit - 400) * 8 + 500 + 600 + 700;
                    break;

                default:
                    return Amount = 100;
                    break;
            }
            Console.WriteLine($"your Bill amount is {Amount} fot unit{unit}");
        }
    }
}