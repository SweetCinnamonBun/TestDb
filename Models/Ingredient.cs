using System;
using System.Collections.Generic;

namespace TestDb.Models;

public partial class Ingredient
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
