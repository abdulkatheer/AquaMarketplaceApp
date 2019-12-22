using System.Threading;
using System.Threading.Tasks;
using Domain.Model;
using MediatR;
using Persistence.Context;

namespace Application.Users
{
    public class Find
    {
        public class Query : IRequest<User>
        {
            public int Id { get; set; }   
        }

        public class Handler : IRequestHandler<Query, User>
        {
            private readonly DatabaseContext _databaseContext;

            public Handler(DatabaseContext databaseContext)
            {
                this._databaseContext = databaseContext;
            }

            public async Task<User> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _databaseContext.Users.FindAsync(request.Id);
            }
        }
    }
}