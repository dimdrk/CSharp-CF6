namespace IgnoreNegatives
{
    /// <summary>
    /// Counts only the negatives.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int negativesCount = 0;

            try
            {
                do
                {
                    Console.WriteLine("Please insert a number (integer)");
                    num = int.Parse(Console.ReadLine()!);
                    if (num > 0) continue;
                    negativesCount++;
                    if (num == 0) break;
                } while (true);
            } catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }            
        }
    }
}
