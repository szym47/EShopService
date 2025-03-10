﻿using System.ComponentModel;

namespace EShopservice.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Ean { get; set; } = default!;
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Sku { get; set; } = default!;
    public Category Category { get; set; } = default!;
    public bool Deleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public Guid UpdatedBy { get; set; }
}
