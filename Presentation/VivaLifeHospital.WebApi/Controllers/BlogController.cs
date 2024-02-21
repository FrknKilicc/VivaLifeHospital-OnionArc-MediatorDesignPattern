using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivaLifeHospital.Application.Features.Mediator.Commands.BlogCommands;
using VivaLifeHospital.Application.Features.Mediator.Handlers.BlogHandlers;
using VivaLifeHospital.Application.Features.Mediator.Queries.BlogQueries;

namespace VivaLifeHospital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var value = await _mediator.Send(new GetBlogQuery());
            return Ok(value);
        }
        [HttpGet("GetBlogWithAuthorNdCategory")]
        public async Task<IActionResult> GetBlogWithAuthorNdCategory()
        {
            var value = await _mediator.Send(new GetBlogWithAuthorNdCategoryQuery());
            return Ok(value);
        }
        [HttpGet("GetLast3Blog")]
        public async Task<IActionResult> GetLast3Blog()
        {
            var value = await _mediator.Send(new GetLast3BlogQuery());
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(int id)
        {
            var value = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }
        [HttpGet("GetBlogByIdWithAuthor")]
        public async Task<IActionResult> GetBlogByIdWithAuthor(int id)
        {
            var value = await _mediator.Send(new GetBlogByIdWithAuthorIdQuery(id));
            return Ok(value);
        } 
        [HttpGet("GetBlogBySearch")]
        public async Task<IActionResult> GetBlogBySearch(string keyword)
        {
            var value = await _mediator.Send(new GetBlogBySearchQuery(keyword));
            return Ok(value);
        }

       
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Bilgisi Başarıyla Kayıt Edildi");
        }
        [HttpPut]
        public async Task<IActionResult>  UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Bilgisi Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return Ok("Blog Bilgisi Başarıyla Silindi");
        }
       
    }
}
