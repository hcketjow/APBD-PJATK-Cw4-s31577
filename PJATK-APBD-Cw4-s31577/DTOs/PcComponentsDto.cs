namespace PJATK_APBD_Cw4_s31577.DTOs;

public class PcComponentsDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ComponentItemDto> Components { get; set; } = new();
}

public class ComponentItemDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Amount { get; set; }
}
