using Persistence.Context;
using Domain.Model;
using System.Linq;
using System.Collections.Generic;

namespace Persistence.Bootstrap
{
    public class Seed
    {
        public static void SeedData(DatabaseContext databaseContext)
        {
            //seeding User data on boot
            if (! databaseContext.Users.Any())
            {
                var users = new List<User> {
                    new User 
                    {
                        MobileCountryCode = "91", 
                        MobileNumber="9973992893", 
                        ContactName="Mohideen Abdul Katheer M",
                        CompanyName="IG", 
                        CompanyType="IT", 
                        NaupliiSupplier="None", 
                        Country="India", 
                        State="Karnataka",
                        Area="Bangalore", 
                        Address="Domlur", 
                        ReferralCode="None"
                    },

                    new User 
                    {
                        MobileCountryCode = "91", 
                        MobileNumber="9927836728", 
                        ContactName="Dhanalakshmi N",
                        CompanyName="Accenture", 
                        CompanyType="IT", 
                        NaupliiSupplier="None", 
                        Country="India", 
                        State="Tamilnadu",
                        Area="Chennai", 
                        Address="TNagar", 
                        ReferralCode="None"
                    },

                    new User 
                    {
                        MobileCountryCode = "91", 
                        MobileNumber="8816838828", 
                        ContactName="Faizal Ahamaed M",
                        CompanyName="Naga Foods", 
                        CompanyType="Food Manufacturing", 
                        NaupliiSupplier="None", 
                        Country="India", 
                        State="Tamilnadu",
                        Area="Dindigul", 
                        Address="Seelapadi", 
                        ReferralCode="None"
                    },   

                    new User 
                    {
                        MobileCountryCode = "91", 
                        MobileNumber="7927927831", 
                        ContactName="Vinothkumar N",
                        CompanyName="Kaar Tech", 
                        CompanyType="SAP Consulting", 
                        NaupliiSupplier="None", 
                        Country="India", 
                        State="Tamilnadu",
                        Area="Chennai", 
                        Address="Tambaram", 
                        ReferralCode="None"
                    },  

                    new User 
                    {
                        MobileCountryCode = "91", 
                        MobileNumber="8028837829", 
                        ContactName="Hari K",
                        CompanyName="Kaar Tech", 
                        CompanyType="SAP Consulting", 
                        NaupliiSupplier="None", 
                        Country="India", 
                        State="Tamilnadu",
                        Area="Chennai", 
                        Address="Tambaram", 
                        ReferralCode="None"
                    }            
                };

                databaseContext.Users.AddRange(users);
                databaseContext.SaveChanges();
            }

        }
    }
}