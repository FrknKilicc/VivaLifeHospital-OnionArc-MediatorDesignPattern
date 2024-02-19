using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivaLifeHospital.Application.Features.Mediator.Commands.TagsCloudCommands;
using VivaLifeHospital.Application.Features.Mediator.Queries.TagsCloudQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsCloudController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagsCloudController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> TagsCloudList()
        {
            var values= await _mediator.Send(new GetTagsCloudQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> TagsCloudById(int id)
        {
            var values = await _mediator.Send(new GetTagsCloudByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTagsCloud(CreateTagsCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("Etiket Ekleme İşlemi Başarıyla Gerçekleşti.");

        }
        [HttpPut]
        public async Task<IActionResult> UpdateTagsCloud(UpdateTagsCloudCommand command)
        {
             await _mediator.Send(command);
            return Ok("Etiket Güncelleme İşlemi Başarıyla Gerçekleşti.");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveTagsCloud(int id)
        {
            await _mediator.Send(new RemoveTagsCloudCommand(id));
            return Ok();
        }
    }
}
