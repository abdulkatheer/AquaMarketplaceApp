using Domain.Model;
using Persistence.Context;

namespace Application.Service
{
    public class RegistrationService
    {
        private readonly DatabaseContext _database;
        //injecting DatabaseContext to service class
        public RegistrationService(DatabaseContext database)
        {
            this._database = database;
        }

        public string RegisterUser(User user) {
            // ToDo
            // 1) Validate User data

            // 2) If valid, save data to table and return success

            // 3) If not valid, return validation errors
            
            //returns success or error
            return null;
        }
    }
}