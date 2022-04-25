using MediatR;
using MovieManagement.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Library.Commands
{
    public record AddMovieCommand(MovieModel model) : IRequest<MovieModel>;
    
}
