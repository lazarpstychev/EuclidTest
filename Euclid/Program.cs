namespace Euclid
{
    public class Program
    {
        static void Main(string[] args)
        {
            { Console.WriteLine(NOD(24,88)); }
        }
        public static int NOD(int a, int b)
        {
            
            {
               // a = Math.Abs(a);
              // b = Math.Abs(b);
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

        }

    }
}
