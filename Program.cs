namespace IMAT_GitTest
{
    internal class Program
    {
        public static int Add(int x, int y)
            {
                return x + y;
            }

        public static int Multiply(int x, int y)
            {
                return x * y;
            }

        public static int Divide(int x, int y)
            {
                if (y == 0)
            {
                Console.WriteLine("El divisor no puede ser cero.");
            }
            return x / y;
        }

        
        static void Main(string[] args)
        {
            int ID_Javier = 202407851;
            int ID_Pedro = 202306656;

            Console.WriteLine($"El producto del primer y último término del ID es: {Multiply(ID_Pedro[0], ID_Pedro[8])}");
        }
    }
}
