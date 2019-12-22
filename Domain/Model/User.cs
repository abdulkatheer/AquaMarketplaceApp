namespace Domain.Model
{

    public enum CompanyType
    {
        Hatchery,
        Farm,
        Consultant

    }
    public class User
    {
        public int Id { get; set;}
        
        public string MobileCountryCode { get; set;} = "91";

        public string MobileNumber { get; set;}

        public string ContactName { get; set;}

        public string CompanyName { get; set;}

        public CompanyType CompanyType { get; set;}

        public bool NaupliiSupplier { get; set;}

        public string Country { get; set;} = "India";

        public string State { get; set;}

        public string Area { get; set;}

        public string Address { get; set;}

        public string ReferralCode { get; set;}
    }
}