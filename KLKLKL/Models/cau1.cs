using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KLKLKL.Models;

[Table("cau1")]

public class cau1 {

    [Key]

    public int Id { get; set; }

    public string Name { get; set; }

    public float Heigh {get; set; } 
}
