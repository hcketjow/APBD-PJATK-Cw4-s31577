using Microsoft.AspNetCore.Mvc;
using PJATK_APBD_Cw4_s31577.DTOs;
using PJATK_APBD_Cw4_s31577.Service;

namespace PJATK_APBD_Cw4_s31577.Controllers;

[ApiController]
[Route("api/pcs")]
public class PcsController : ControllerBase
{
    private readonly IPcService _service;

    public PcsController(IPcService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var pcs = await _service.GetAllAsync();
        return Ok(pcs);
    }

    [HttpGet("{id}/components")]
    public async Task<IActionResult> GetComponents(int id)
    {
        var result = await _service.GetComponentsAsync(id);
        if (result == null)
            return NotFound();

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] PcCreateDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var created = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetComponents), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] PcUpdateDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var updated = await _service.UpdateAsync(id, dto);
        if (!updated)
            return NotFound();
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _service.DeleteAsync(id);
        if (!deleted)
            return NotFound();
        return NoContent();
    }
}
