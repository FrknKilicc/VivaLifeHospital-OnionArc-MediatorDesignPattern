using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivaLifeHospital.Application.Features.Mediator.Commands.CommentCommands;
using VivaLifeHospital.Application.Features.Mediator.Queries.CommentQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CommentList()
        {
            var values = await _mediator.Send(new GetCommentQuery());
            return Ok(values);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentById(int id)
        {
            var values = await _mediator.Send(new GetCommentByIdQuery(id));
            return Ok(values);
        }   
        [HttpGet("GetCommentByBlogId")]
        public async Task<IActionResult> GetCommentByBlogId(int id)
        {
            var values = await _mediator.Send(new GetCommentByBlogIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yorum Başarıyla Kaydedildi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateComment(UpdateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yorum Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveComment(int id)
        {
            await _mediator.Send(new RemoveCommentCommand(id));
            return Ok("Yorum Başarıyla Silindi");
        }
    }
}
