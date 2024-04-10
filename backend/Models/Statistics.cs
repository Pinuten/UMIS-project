using System.ComponentModel.DataAnnotations;

public class Statistics
{
    [Key]
    public int Id {get; set;}
    public int Eaten {get; set;}
}