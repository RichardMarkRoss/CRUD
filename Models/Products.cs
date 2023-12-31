﻿using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}
