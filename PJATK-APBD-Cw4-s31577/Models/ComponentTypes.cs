using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PJATK_APBD_Cw4_s31577.Models;

public class ComponentTypes
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(30), Column(TypeName = "nvarchar(30)")]
    public String Abbreviation { get; set; }
    
    [MaxLength(150), Column(TypeName = "nvarchar(150)")]
    public String Name { get; set; }
}
