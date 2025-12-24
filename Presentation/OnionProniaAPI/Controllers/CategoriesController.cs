
using Microsoft.AspNetCore.Mvc;
using OnionPronia.Application.DTOs;
using OnionPronia.Application.Interfaces.Services;

namespace OnionProniaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {


        private readonly ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {


            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int page, int take)
        {

            return Ok(await _service.GetAllAsync(page, take));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            if (id is null || id < 1) return BadRequest();

            return Ok(await _service.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] PostCategoryDto categoryDto)
        {

            await _service.CreateAsync(categoryDto);
            return Created();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int? id, [FromForm] PutCategoryDto categoryDto)
        {
            if (id < 1) return BadRequest();
            await _service.UpdateAsync(id.Value, categoryDto);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> Remove(int? id)
        {
            if (id is null || id < 1) return BadRequest();
            await _service.DeleteAsync(id.Value);

            return NoContent();
        }
    }
}
