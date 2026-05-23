using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PJATK_APBD_Cw4_s31577.Models;

[Table("ComponentTypes")]
public class ComponentTypes
{
    [Key]
    public int Id { get; set; }
    
    [Required, MaxLength(30)]
    public string Abbreviation { get; set; }
    
    [Required, MaxLength(150)]
    public string Name { get; set; }
    
    public virtual ICollection<Components> Components { get; set; }
}
