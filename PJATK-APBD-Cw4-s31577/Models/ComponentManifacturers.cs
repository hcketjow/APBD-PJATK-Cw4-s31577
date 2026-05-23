using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PJATK_APBD_Cw4_s31577.Models;

[Table("ComponentManifacturers")]
public class ComponentManifacturers
{
    [Key]
    public int Id { get; set; }
    
    [Required, MaxLength(30)]
    public string Abbreviation { get; set; }
    
    [Required, MaxLength(300)]
    public String FullName { get; set; }
    
    [Column(TypeName = "date")]
    public DateTime FoundationDate { get; set; }
    
    public virtual ICollection<Components> Components { get; set; }
}
