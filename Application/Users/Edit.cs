using System.Threading;
using System.Threading.Tasks;
using Domain.Model;
using MediatR;
using Persistence.Context;

namespace Application.Users
{
    public class Edit
    {
        public class Command : IRequest
        {
            public int Id { get; set;}
        
            public string MobileCountryCode { get; set;}

            public string MobileNumber { get; set;}

            public string ContactName { get; set;}

            public string CompanyName { get; set;}

            public CompanyType? CompanyType { get; set;}

            public bool? NaupliiSupplier { get; set;}

            public string Country { get; set;}

            public string State { get; set;}

            public string Area { get; set;}

            public string Address { get; set;}

            public string ReferralCode { get; set;}
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

                if (user == null)
                {
                    throw new System.Exception("User not found");
                }

                user.MobileCountryCode = request.MobileCountryCode ?? user.MobileCountryCode;
                user.MobileNumber = request.MobileNumber ?? user.MobileNumber;
                user.ContactName = request.ContactName ?? user.ContactName;
                user.CompanyName = request.CompanyName ?? user.CompanyName;
                user.CompanyType = request.CompanyType ?? user.CompanyType;
                user.NaupliiSupplier = request.NaupliiSupplier ?? user.NaupliiSupplier;
                user.Country = request.Country ?? user.Country;
                user.State = request.State ?? user.State;
                user.Area = request.Area ?? user.Area;
                user.Address = request.Address ?? user.Address;
                user.ReferralCode = request.ReferralCode ?? user.ReferralCode;

                var success = await _databaseContext.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new System.Exception("Error while updating user");
            }
        }
    }
}