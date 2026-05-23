using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PJATK_APBD_Cw4_s31577.Models;

public class PCComponents
{
    [Key]
    public int PCId { get; set; }
    
    [MaxLength(10), Column(TypeName = "char(10)")]
    public String ComponentCode { get; set; }
    
    public int Amount { get; set; }
}
