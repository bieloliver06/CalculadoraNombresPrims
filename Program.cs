namespace ActivitatVoluntaria
{
    class Program
    {

        static void Main()
        {
            int upTo;
            while (true)
            {
                Console.WriteLine("Introdueix fins a quin nombre vols saber si es prim : ");
                string? s_upTo = Console.ReadLine();
                if (s_upTo != null)
                {
                    try
                    {
                        upTo = Math.Abs(Convert.ToInt32(s_upTo));
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid");
                    }
                }
            }
            for (int i = 2; i <= upTo; i++)
            {
                IsPrime(i);
            }
        }
        static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0 && i != number) return false;

            }
            Console.WriteLine($"El nombre {number} es prim");
            return true;
        }
    }
}