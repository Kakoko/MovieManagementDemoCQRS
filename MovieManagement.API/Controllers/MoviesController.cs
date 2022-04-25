using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Library.Commands;
using MovieManagement.Library.Models;
using MovieManagement.Library.Queries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<MoviesController>
        [HttpGet]
        public async Task<List<MovieModel>> Get()
        {
            return await _mediator.Send(new GetMovieListQuery());
        }


        [HttpGet("{id}")]
        public async Task<MovieModel> Get(int id)
        {
            return await _mediator.Send(new GetMovieByIdQuery(id));
        }

        [HttpPost]
        public async Task<MovieModel> Post(MovieModel movieModel)
        {
            return await _mediator.Send(new AddMovieCommand(movieModel));
        }
        

       
    }
}
