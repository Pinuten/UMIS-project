using System;

public class Matlada
{
    public string Guid { get; set; }

    public Size Size { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Name { get; set; }

    public Matlada(string guid, Size size, DateTime createdAt, string name)
    {
        Guid = guid;
        Size = size;
        CreatedAt = createdAt;
        Name = name;
    }
}

public enum Size
{
    Normal,
    Small
}
