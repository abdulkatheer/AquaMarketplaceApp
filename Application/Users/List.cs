using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Application.Users
{
    public class List
    {
        public class Query : IRequest<List<User>> 
        {

        }

        public class Handler : IRequestHandler<Query, List<User>>
        {
            private readonly DatabaseContext _databaseContext;

            public Handler(DatabaseContext databaseContext)
            {
                this._databaseContext = databaseContext;
            }

            public async Task<List<User>> Handle(Query request, CancellationToken cancellationToken)
            {
                var users = await _databaseContext.Users.ToListAsync();
                return users;
            }
        }
    }
}