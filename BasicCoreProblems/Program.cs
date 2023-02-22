namespace BasicCoreProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Basic Core Programs");
            Console.WriteLine("\n1:HeadAndTail\n2:LeapYear\n3:Powerof2\n4:HarmonicNumber\n5:PrimeFactors\n6:RemainderAndQuotient\n11:Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    HeadAndTail.HeadandTailPercentage();
                    break;
                case 2:
                    LeapYear.LeapYearCheck();
                    break;
                case 3:
                    Powerof2.PowerTwo();
                    break;
                case 4:
                    HarmonicNumber.HarmonicValue();
                    break;
                case 5:
                    PrimeFactors.PrimeFactor();
                    break;
                case 6:
                    RemainderAndQuotient.Divmethod();
                    break;
                default:
                    Console.WriteLine("choose the above options");
                    break;
            }
            Console.ReadLine();
        }


    }
}

