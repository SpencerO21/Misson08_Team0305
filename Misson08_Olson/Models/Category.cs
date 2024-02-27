using System;
using System.Collections.Generic;

namespace Misson08_Olson.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
