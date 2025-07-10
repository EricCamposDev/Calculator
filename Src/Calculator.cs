using Src.Dictionaries;
using Src.Enums;

namespace Src.Calculator;

struct Calculator
{
    public bool running;
    string? input { get; set; }


    float numberOne { get; set; }
    float numberTwo { get; set; }
    char operation { get; set; }


    float? output { get; set; }
    bool calculate { get; set; }
    string navigator { get; set; }
    readonly char[] operations;
    readonly string[] commands;

    private static List<Log> logs = new List<Log>();
    private static int counter = 1;

    public Calculator()
    {
        operations = ['+', '-', '*', '/'];
        commands = ["calculate", "history", "help", "exit"];
        navigator = MessagesNavigate.Navs[Navigatorkeys.Home];
    }

    public void init()
    {
        running = true;
        calculate = false;

        Console.Clear();
        Console.Write(MessagesStore.Texts[Messageskeys.Header]);
    }


    public void cli()
    {
        if (calculate)
        {
            if (numberOne == 0)
            {
                Console.Write($"\n{navigator}: [ _ _ _ ] -  primeiro numero:");

                input = Console.ReadLine();
                if (input == "exit")
                {
                    calculate = false;
                    return;
                }

                numberOne = float.Parse(input ?? "");
            }

            Console.Write($"\n{navigator}: [ {numberOne} _ _ ] qual a operação:");
            operation = Console.ReadKey().KeyChar;

            if (operations.Contains(operation))
            {
                if (numberTwo == 0)
                {

                    Console.Write($"\n{navigator}: [ {numberOne} {operation} _ ] segundo numero:");

                    input = Console.ReadLine();
                    if (input == "exit")
                    {
                        calculate = false;
                        return;
                    }

                    numberTwo = float.Parse(input ?? "");
                }


                Arithmetic arithmetic = new(numberOne, numberTwo);
                output = arithmetic.calculate(operation);

                Console.WriteLine($"\nSaida: {numberOne} {operation} {numberTwo} = {output}");
                storage();
            }
            else
            {
                Console.WriteLine($"{navigator}: Erro: O operador aritmético não é valido.");
            }
        }
        else
        {
            Console.Write($"{navigator}: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "calc":
                    calculate = true;
                    navigator = MessagesNavigate.Navs[Navigatorkeys.Calculate];
                    break;

                case "help":
                    calculate = false;
                    navigator = MessagesNavigate.Navs[Navigatorkeys.Help];
                    Console.Write(MessagesStore.Texts[Messageskeys.Help]);
                    break;

                case "logs":
                    calculate = false;
                    navigator = MessagesNavigate.Navs[Navigatorkeys.Logs];

                    foreach (var log in logs)
                    {
                        Console.WriteLine(log);
                    }

                    break;

                case "exit":
                    Console.Write(MessagesStore.Texts[Messageskeys.Footer]);
                    running = false;
                    break;
            }
        }

    }

    private void storage()
    {
        logs.Add(new Log(counter++, $"{numberOne} {operation} {numberTwo} = {output}"));
        Console.WriteLine($"* Expressão salva em memória!\n registros: {logs.Count}");
        numberOne = default;
        numberTwo = default;
        operation = default;
        output = default;
    }
}