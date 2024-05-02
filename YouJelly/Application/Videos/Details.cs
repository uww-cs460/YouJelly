using System.Threading;
using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence;
using Domain;
using MediatR;

namespace Application.Videos
{
    public class Details
    {

        public class Query : IRequest<Video>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Video>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Video> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Videos.FindAsync(request.Id);
            }

        }

    }
}