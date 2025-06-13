using CRUD_LayeredArchitecture.Application.Services;
using CRUD_LayeredArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_LayeredArchitecture.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        private readonly TaxService _taxService;

        public TaxController(TaxService taxService)
        {
            _taxService = taxService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _taxService.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var tax = await _taxService.GetByIdAsync(id);

            return tax == null ? NotFound() : Ok(tax);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TaxEntity tax)
        {
            await _taxService.AddAsync(tax);

            return CreatedAtAction(nameof(GetById), new { id = tax.Id }, tax);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, TaxEntity tax)
        {
            if (id != tax.Id) 
                return BadRequest("ID mismatch.");

            await _taxService.UpdateAsync(tax);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _taxService.DeleteAsync(id);

            return NoContent();
        }
    }
}
