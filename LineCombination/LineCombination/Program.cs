namespace LineCombination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Combination Computaion");
            LineComparisionComput lineComb = new LineComparisionComput();
            lineComb.lengthOFLine();
            lineComb.CheckEqualLines();
            Console.ReadKey();
        
        }
    }
}