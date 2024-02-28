using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Misson08_Olson.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public required string Task1 { get; set; } ;

    public string? DueDate { get; set; }

    public int QuadId { get; set; }

    public int CategoryId { get; set; }

    public int Completed { get; set; }

    [ForeignKey("CategoryId")]
    public virtual required Category Category { get; set; }
}
