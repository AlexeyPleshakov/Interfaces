namespace Task2
{
    public interface ICalculator 
    {
        void CalcSum(double x, double y);
    }
    public interface ILogger
    {
        void Event (string message);

        void Error (string message);
    }

    class Program
    {
        // На 17 строчку мне IDE выдаёт предупреждение, что 
        // свойство логгер должно иметь значение !null на выходе из
        // конструктора(??). А так всё работает
        static ILogger Logger { get; set; }
        static void Main()
        {
            double num1, num2;

            Logger = new Logger();
            Calculator mycalculator = new Calculator(Logger);

            Console.Write("Type a number, and then press Enter: ");

            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Your next number:");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Result:");

                mycalculator.CalcSum(num1, num2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error! Exception:\n" + ex.Message);
            }
        }
    }
}
