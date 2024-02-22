using System.ComponentModel.Design;

namespace gamoicaniRicxvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GamoicaniRicxvi();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("lets try again");
                GamoicaniRicxvi();
            }
            void GamoicaniRicxvi()
            {
                Random random = new Random();
                int x = random.Next(20);
                Console.WriteLine("Gamoicanit ricxvi");
                for (int i = 0; i < 5; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out int myNumber))
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        throw new Exception("please choose valid number");
                    }
                    if (myNumber == x)
                    {
                        Console.WriteLine("you are right");
                        return;
                        Console.ReadKey();
                    }
                    else if (myNumber > x)
                    {
                        Console.WriteLine("Its too big, lets try again");
                    }
                    else
                    {
                        Console.WriteLine("Its too little, lets try again");
                    }
                }
                Console.WriteLine("Game over, you lose");
                Console.ReadKey();
            }
        }
    }
}