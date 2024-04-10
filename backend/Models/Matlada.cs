using System;
using System.ComponentModel.DataAnnotations;

public class Matlada
{
    [Key]
    public int Id { get; set; }

    public string Guid { get; set; } = System.Guid.NewGuid().ToString();
    public Size Size { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Name { get; set; }

}

public enum Size
{
    Normal,
    Small
}
