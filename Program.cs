namespace Switchiga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta number");
            int number =Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("sisestasid numbri 1")
                        ; break;
                case 2:
                    Console.WriteLine("sisestasid nr 2");
                    break;
                case 3:
                    Console.WriteLine("sisestasid nr 3");
                    break;
                default:
                    Console.WriteLine("pole nr 1-3");
                    break;
            }
        }
    }
}
