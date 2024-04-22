namespace Task1
{
    interface ICalculator
    {
        double CalcSum(double x, double y);
    }

    class Program: ICalculator
    {
        public double CalcSum(double x, double y)
        {
            return x + y;
        }
        static void Main()
        {
            double num1, num2;

            Program calculator = new Program();
            Console.Write("Type a number, and then press Enter: ");

            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Your next number:");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Result:");

                var res = calculator.CalcSum(num1, num2);
                Console.WriteLine(res);
            }
            catch(FormatException ex) 
            {
                Console.WriteLine("Error! Exception:\n" + ex.Message);
            }
        }
    }
}