#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

public class Result
{
    [Required]
    [MinLength(3)]
    public string Name { get; set; }
    [Required]
    [MinLength(3)]
    public string Location { get; set; }
    [Required]
    [MinLength(3)]
    public string Language { get; set; }
    
    [MinLength(25)]
    public string? Comment { get; set; }

}

