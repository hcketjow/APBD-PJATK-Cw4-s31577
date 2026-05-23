using Microsoft.EntityFrameworkCore;
using PJATK_APBD_Cw4_s31577.DTOs;
using PJATK_APBD_Cw4_s31577.Models;
using PJATK_APBD_Cw4_s31577.Service;

namespace PJATK_APBD_Cw4_s31577.Services;

public class PcService : IPcService
{
    private readonly DatabaseContext _context;

    public PcService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<List<PcGetAllDto>> GetAllAsync()
    {
        return await _context.PCs
            .Select(pc => new PcGetAllDto
            {
                Id = pc.Id,
                Name = pc.Name,
                Weight = pc.Weight,
                Warranty = pc.Warranty,
                CreatedAt = pc.CreatedAt,
                Stock = pc.Stock
            })
            .ToListAsync();
    }

    public async Task<PcComponentsDto?> GetComponentsAsync(int pcId)
    {
        var pc = await _context.PCs
            .Where(p => p.Id == pcId)
            .Select(p => new PcComponentsDto
            {
                Id = p.Id,
                Name = p.Name,
                Components = p.PCComponents
                    .Select(pcc => new ComponentItemDto
                    {
                        Code = pcc.Component.Code,
                        Name = pcc.Component.Name,
                        Description = pcc.Component.Description,
                        Amount = pcc.Amount
                    })
                    .ToList()
            })
            .FirstOrDefaultAsync();
        return pc;
    }

    public async Task<PcCreatedResponseDto> CreateAsync(PcCreateDto dto)
    {
        var pc = new PCs
        {
            Name = dto.Name,
            Weight = dto.Weight,
            Warranty = dto.Warranty,
            CreatedAt = dto.CreatedAt,
            Stock = dto.Stock
        };
        _context.PCs.Add(pc);
        await _context.SaveChangesAsync();
        
        return new PcCreatedResponseDto
        {
            Id = pc.Id,
            Name = pc.Name,
            Weight = pc.Weight,
            Warranty = pc.Warranty,
            CreatedAt = pc.CreatedAt,
            Stock = pc.Stock
        };
    }

    public async Task<bool> UpdateAsync(int id, PcUpdateDto dto)
    {
        var pc = await _context.PCs.FindAsync(id);
        if (pc == null)
            return false;
        pc.Name = dto.Name;
        pc.Weight = dto.Weight;
        pc.Warranty = dto.Warranty;
        pc.CreatedAt = dto.CreatedAt;
        pc.Stock = dto.Stock;
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var pc = await _context.PCs.Include(p => p.PCComponents).FirstOrDefaultAsync(p => p.Id == id);
        if (pc == null)
            return false;
        _context.PCComponents.RemoveRange(pc.PCComponents);
        _context.PCs.Remove(pc);
        await _context.SaveChangesAsync();
        return true;
    }
}
