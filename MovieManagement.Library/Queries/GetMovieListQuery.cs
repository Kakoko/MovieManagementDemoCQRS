using MediatR;
using MovieManagement.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Library.Queries
{
    public record GetMovieListQuery() : IRequest<List<MovieModel>>;
}
