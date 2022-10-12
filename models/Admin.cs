nnamespace FDMS.models
{
    public class Admin:User
    {
        public string Id{get; set;}
        public string  Wallet{get;set;}

        public Admin(string fistName ,string lastName,string email,string pin ,string id, string wallet):base(fistname,lastname,email,pin )

        {
            FirstName = fistName;
            Email = email;
            LastName = lastName;
            Pin = pin;
            Id = id;
            Wallet = wallet
        }
    }
   
}