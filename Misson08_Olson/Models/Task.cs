using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Misson08_Olson.Models;

public partial class Task
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TaskId { get; set; }

    public string? Task1 { get; set; } 

    public string? DueDate { get; set; }
    [Range(1, 4)]
    public int QuadId { get; set; }

    public int CategoryId { get; set; }

    public bool Completed { get; set; }

    [ForeignKey("CategoryId")]
    public virtual Category? Category { get; set; }
}
