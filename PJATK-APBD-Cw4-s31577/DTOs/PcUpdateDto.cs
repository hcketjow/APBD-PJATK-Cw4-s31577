using System.ComponentModel.DataAnnotations;

namespace PJATK_APBD_Cw4_s31577.DTOs;

public class PcUpdateDto
{
    [Required, MaxLength(50)]
    public string Name { get; set; }

    [Required]
    public float Weight { get; set; }

    [Required]
    public int Warranty { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    [Required]
    public int Stock { get; set; }
}
