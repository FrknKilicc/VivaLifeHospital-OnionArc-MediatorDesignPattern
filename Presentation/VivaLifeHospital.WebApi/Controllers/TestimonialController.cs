using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivaLifeHospital.Application.Features.Mediator.Commands.TestimonialCommands;
using VivaLifeHospital.Application.Features.Mediator.Queries.TestimonialQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly IMediator mediator;

        public TestimonialController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var value = await mediator.Send(new GetTestimonialQuery());
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonialById(int id)
        {
            var value = await mediator.Send(new GetTestimonialByIdQuery(id));
            return Ok(value);   
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
        {
            await mediator.Send(command);
            return Ok("Yorum Bilgisi Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
        {
            await mediator.Send(command);
            return Ok("Yorum Bilgisi Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveTestimonail(int id)
        {
            await mediator.Send(new RemoveTestimonialCommand(id));
            return Ok("Yorum Bilgisi Başarıyla Silindi");
        }
    }
}
