using System;
using System.Collections.Generic;

namespace LoginFormAspCore6.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public int Quantity { get; set; }

    public int Value { get; set; }
}
