namespace Static
{
    internal class Program
    {
        public static class MyCalculator
        {
            public static double Add(double x, double y)
            {
                return x + y; 
            }
            public static double Subtract(double x, double y) 
            {
                return x - y; 
            }
            public static double Multiply(double x, double y)
            {
                return x * y;
            }
            public static double Divide(double x, double y)
            {
                if (y == 0)
                {
                    Console.WriteLine("Error!!");
                    return double.NaN;
                }
                else
                {
                    return x / y;
                }
            }
            public static double Squared(double x, double y)
            {
                return Math.Pow(x, y);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("계산기를 이용할 첫 번째 수를 입력해주세요.");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("두 번째 수를 입력해주세요.");
            double.TryParse(Console.ReadLine(), out double y);

            Console.WriteLine($"{x} + {y} = {MyCalculator.Add(x, y)}");
            Console.WriteLine($"{x} - {y} = {MyCalculator.Subtract(x, y)}");
            Console.WriteLine($"{x} * {y} = {MyCalculator.Multiply(x, y)}");
            Console.WriteLine($"{x} / {y} = {MyCalculator.Divide(x, y)}");
            Console.WriteLine($"{x} ^ {y} = {MyCalculator.Squared(x, y)}");
        }
    }
}
