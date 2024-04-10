using System;
using System.ComponentModel.DataAnnotations; 

public class Matlada
{
    [Key] 
    public int Id { get; set; }

    public required string Guid { get; set; }
    public required Size Size { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required string Name { get; set; }
}

public enum Size
{
    Normal,
    Small
}
