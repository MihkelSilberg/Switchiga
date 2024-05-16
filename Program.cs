namespace Switchiga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vajuta 1 kui tahad valikut ja 2 kui ei taha");
            string valikud = Console.ReadLine();
           if (valikud == "1")
            {
                SwitchMethod();
            }
           else if (valikud == "2")
            {
                Console.WriteLine("ei valinud");
            }

        }
        static void SwitchMethod()
        {
             Console.WriteLine("ma loen teie mõtteid. vali nr 1-3");
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
