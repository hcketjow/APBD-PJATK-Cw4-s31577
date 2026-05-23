using PJATK_APBD_Cw4_s31577.DTOs;

namespace PJATK_APBD_Cw4_s31577.Service;

public interface IPcService
{
    Task<List<PcGetAllDto>> GetAllAsync();
    Task<PcComponentsDto?> GetComponentsAsync(int pcId);
    Task<PcCreatedResponseDto> CreateAsync(PcCreateDto dto);
    Task<bool> UpdateAsync(int id, PcUpdateDto dto);
    Task<bool> DeleteAsync(int id);
}
