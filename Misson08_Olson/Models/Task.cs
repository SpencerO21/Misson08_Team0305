using System;
using System.Collections.Generic;

namespace Misson08_Olson.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public string Task1 { get; set; } = null!;

    public string? DueDate { get; set; }

    public int QuadId { get; set; }

    public int CategoryId { get; set; }

    public int Completed { get; set; }

    public virtual Category Category { get; set; } = null!;
}
