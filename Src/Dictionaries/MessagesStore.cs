using Src.Enums;

namespace Src.Dictionaries;

public static class MessagesStore
{
    public static Dictionary<Messageskeys, string> Texts = new()
    {
        {Messageskeys.Header, @"
            ======== CALCULADORA BALTA IO ========

            Operações permitidas:
            + = adição ou soma;
            - = subtração;
            * = multiplicação;
            / = divisão;

            comandos de aplicação:
            calc = inicia um novo calculo;
            history   = historico de calculos;
            help      = ajuda;
            exit      = sair;
        "},
        {Messageskeys.Calculate, "Para calcular, você deve entrar com os 3 valores de entrada."},
        {Messageskeys.History, "Para calcular, você deve entrar com os 3 valores de entrada."},
        {Messageskeys.Help, @"
            ======== CALCULADORA BALTA IO ========

            Central de ajuda

            Operações permitidas:
            + = adição ou soma;
            - = subtração;
            * = multiplicação;
            / = divisão;

            comandos de aplicação:
            calc = inicia um novo calculo;
            history   = historico de calculos;
            help      = ajuda;
            exit      = sair;

            1 - Os numeros de entrada 1 e 2 devem ser obrigatoriamente numericos, 
                podendo ser float ou int.
            2 - Em qualquer momento de entrada é possivel inserir o comando 'exit' 
                para encerrar uma operação de calculo ou fechar o programa (exceto
                ao inserir o operador artimético, pois seu tipo é diferente).
        "},
        {Messageskeys.Footer, @"
            ======== CALCULADORA BALTA IO ========
            developed by: Eric Campos (github: EricCamposDev)

            --------       ATÉ MAIS     ----------
        "}
    };
}