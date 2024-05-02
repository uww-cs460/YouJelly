using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Domain;
using MediatR;
using Persistence;
using Microsoft.Extensions.Logging;

namespace Application.Videos
{
    public class List_C
    {
        public class Query : IRequest<List<Video>> {}

        public class Handler : IRequestHandler<Query, List<Video>> 
        {
            private readonly DataContext _context;
            private readonly ILogger<List_C> _logger;
            public Handler(DataContext context, ILogger<List_C> logger)
            {
                _logger = logger;
                _context = context;

            }

            public async Task<List<Video>> Handle(Query request, CancellationToken cancellationToken)
            {


                return await _context.Videos.ToListAsync();
            }
        }
    }
}