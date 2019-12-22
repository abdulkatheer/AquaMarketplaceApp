using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence.Context;

namespace Application.Users
{
    public class Delete
    {
        public class Command : IRequest
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DatabaseContext _databaseContext;

            public Handler(DatabaseContext databaseContext)
            {
                this._databaseContext = databaseContext;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _databaseContext.Users.FindAsync(request.Id);

                if (user == null) throw new System.Exception("User not exists");

                _databaseContext.Users.Remove(user);
                
                var success = await _databaseContext.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new System.Exception("Error while deleting user");
            }
        }
    }
}