using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PJATK_APBD_Cw4_s31577.Models;

public class Components
{
    [Key, Column(TypeName = "char(10)")]
    public char Code {get; set;}
    
    [MaxLength(300), Column(TypeName = "nvarchar(300)")]
    public String Name { get; set; }
    
    [Column(TypeName = "nvarchar")]
    public String Description { get; set; }
    
    public int ComponentManufacturerId { get; set; }
    [ForeignKey("ComponentManufacturerId")]
    
    public int componentTypeId { get; set; }
    [ForeignKey("ComponentTypeId")]
    public virtual ComponentTypes ComponentTypes { get; set; }
}
