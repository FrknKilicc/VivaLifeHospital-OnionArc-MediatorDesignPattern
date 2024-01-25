using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using VivaLifeHospital.Application.Features.Mediator.Commands.CategoryCommands;
using VivaLifeHospital.Application.Features.Mediator.Queries.CategoryQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var value = await _mediator.Send(new GetCategoryQuery());
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var value = await _mediator.Send(new GetCategoryByIdQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kategori Bilgisi Güncellendi");

        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kategori Bilgisi Başarıyla Eklendi");
        }
        [HttpDelete]
        public async Task <IActionResult> RemoveCategory(int id)
        {
            await _mediator.Send(new RemoveCategoryCommand(id));
            return Ok("Kategori Bilgisi Başarıyla Silindi");
        }
    }
}
