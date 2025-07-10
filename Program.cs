namespace Calculator;

using Src.Calculator;

class Program
{
    static void Main(string[] args)
    {

        Calculator calc = new();

        calc.init();

        do
        {
            calc.cli();
        }
        while (calc.running);

    }
}
