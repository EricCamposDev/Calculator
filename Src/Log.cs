public struct Log
{
    public int Id;
    public string Calcule;
    public DateTime CreatedIn;

    public Log(int id, string calcule)
    {
        Id = id;
        Calcule = calcule;
        CreatedIn = DateTime.Now;
    }

    public override string ToString()
    {
        return $"ID: {Id} | {CreatedIn:yyyy-MM-dd HH:mm:ss} | {Calcule}";
    }
}
