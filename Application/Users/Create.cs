using System.Threading;
using System.Threading.Tasks;
using Domain.Model;
using MediatR;
using Persistence.Context;

namespace Application.Users
{
    public class Create
    {
        public class Command : IRequest
        {
            public string MobileCountryCode { get; set;}

            public string MobileNumber { get; set;}

            public string ContactName { get; set;}

            public string CompanyName { get; set;}

            public CompanyType CompanyType { get; set;}

            public bool NaupliiSupplier { get; set;}

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
                var user = new User
                {
                    MobileCountryCode = request.MobileCountryCode,
                    MobileNumber = request.MobileNumber,
                    ContactName = request.ContactName,
                    CompanyName = request.CompanyName,
                    CompanyType = request.CompanyType,
                    NaupliiSupplier = request.NaupliiSupplier,
                    Country = request.Country,
                    State = request.State,
                    Area = request.Area,
                    Address = request.Address,
                    ReferralCode = request.ReferralCode
                };

                _databaseContext.Users.Add(user);
                var success = await _databaseContext.SaveChangesAsync() > 0;

                //Just returning empty object
                if (success) return Unit.Value;

                throw new System.Exception("Error while saving user");
            }
        }
    }
}