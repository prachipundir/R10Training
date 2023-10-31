namespace ParallelProgrammimg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Parallel for loop");
            Parallel.For(1, 11, number => {
                Console.WriteLine(number);
            });

            }
        }
    }
