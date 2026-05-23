using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PJATK_APBD_Cw4_s31577.Models;

[Table("PCComponents")]
public class PCComponents
{
    public int PCId { get; set; }
    public virtual PCs PC { get; set; }

    [Column(TypeName = "char(10)")]
    public string ComponentCode { get; set; }
    [ForeignKey(nameof(ComponentCode))]
    public virtual Components Component { get; set; }

    public int Amount { get; set; }
}
