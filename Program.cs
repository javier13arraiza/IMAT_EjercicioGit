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

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
      
        static void Main(string[] args)
        {
            string ID_Javier = "202407851";
            string ID_Pedro = "202306656";

            int primero = ID_Javier[0] - '0';
            int ultimo = ID_Javier[8] - '0';

            Console.WriteLine($"La resta del primer y último término del ID es: {Subtract(primero, ultimo)}");
        }
    }
}
