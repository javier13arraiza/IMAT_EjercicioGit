namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Add(int x, int y)
            {
                return x + y;
            }

            Console.WriteLine($"La suma del primer y último término del ID es: {Add(2,1)}");
        }
    }
}
