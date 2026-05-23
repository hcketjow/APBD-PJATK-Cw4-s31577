using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PJATK_APBD_Cw4_s31577.Models;

public class PCs
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(50), Column(TypeName = "nvarchar(50)")]
    public String Name { get; set; }

    [MaxLength(5)]
    public float Weight;

    public int Warranty;
    
    public DateTime CreatedAt { get; set; }
    
    public int Stock { get; set; }
}
