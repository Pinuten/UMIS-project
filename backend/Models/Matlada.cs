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
    public int EatenCount { get; set; } // New property to count how many times a matlåda has been eaten

}

public enum Size
{
    Normal,
    Small
}
