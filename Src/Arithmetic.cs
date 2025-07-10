
namespace Src;

struct Arithmetic
{
    private float number1 { get; set; }
    private float number2 { get; set; }

    public Arithmetic(float n1, float n2)
    {
        number1 = n1;
        number2 = n2;
    }

    public float calculate(char operation)
    {
        switch (operation)
        {
            case '+': return sum();
            case '-': return subs();
            case '*': return multi();
            case '/': return divider();
            default:
                Console.WriteLine($"Erro Interno: Operação'{operation}' não é considerada uma operação aritmética.");
                return 0;
        }
    }

    public float sum()
    {
        return number1 + number2;
    }

    public float divider()
    {
        return number1 / number2;
    }

    public float subs()
    {
        return number1 - number2;
    }

    public float multi()
    {
        return number1 * number2;
    }
}