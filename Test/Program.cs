namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("greq bnakan tiv 50-ic 70 mijakayqum");

            int tiv = Convert.ToInt32(Console.ReadLine());

            for (int i = 50; i <= 70; i++)
            {


                tiv = i;
                if (tiv % 2 == 0)
                {
                    tiv = tiv / 2;
                }
                else if (tiv % 2 != 0)
                {
                    tiv = (tiv * 3 + 2) / 2;
                }
               
                    Console.WriteLine(tiv);

                
            }
            
            
        }
      }
    }
