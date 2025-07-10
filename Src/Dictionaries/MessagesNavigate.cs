using Src.Enums;

namespace Src.Dictionaries;

public static class MessagesNavigate
{
    public static Dictionary<Navigatorkeys, string> Navs = new()
    {
        {Navigatorkeys.Home, "[C]alculator > inicio"},
        {Navigatorkeys.Calculate, "[C]alculator > cálcular"},
        {Navigatorkeys.Logs, "[C]alculator > logs"},
        {Navigatorkeys.Help, "[C]alculator > Ajuda"}
    };
}