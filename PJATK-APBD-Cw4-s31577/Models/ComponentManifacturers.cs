using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PJATK_APBD_Cw4_s31577.Models;

public class ComponentManifacturers
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(30), Column(TypeName = "nvarchar(30)")]
    public String Abbreviation { get; set; }
    
    [MaxLength(300), Column(TypeName = "nvarchar(300)")]
    public String FullName { get; set; }
    
    [Column(TypeName = "date")]
    public DateTime FoundationDate { get; set; }
}
