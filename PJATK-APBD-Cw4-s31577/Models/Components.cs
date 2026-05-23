using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PJATK_APBD_Cw4_s31577.Models;

[Table("Components")]
public class Components
{
    [Key, Column(TypeName = "char(10)")]
    public string Code {get; set;}
    
    [Required, MaxLength(300)]
    public string Name { get; set; }
    
    [Required, Column(TypeName = "nvarchar(max)")]
    public string Description { get; set; }
    
    public int ComponentManufacturersId { get; set; }
    public virtual ComponentManifacturers ComponentManufacturers { get; set; }

    public int ComponentTypesId { get; set; }
    public virtual ComponentTypes ComponentTypes { get; set; }

    public virtual ICollection<PCComponents> PCComponents { get; set; }
}
