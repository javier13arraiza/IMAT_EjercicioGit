namespace IMAT_GitTest
{
    internal class Program
    {
        static int Add(int x, int y)
            {
                return x + y;
            }

        int ID_Javier = 202407851;
        int ID_Pedro = 202306656;
        
        static void Main(string[] args)
        {
            Console.WriteLine($"La suma del primer y último término del ID es: {Add(2,1)}");
        }
    }
}
