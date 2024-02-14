using System;
using System.Collections.Generic;

namespace LoginFormAspCore6.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Address { get; set; } = null!;

    public int MobileNumber { get; set; }
}
