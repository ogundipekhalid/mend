namespace FDMS.models
{
    public class Coustmer:User
    {
        public string Addres{get; set;}
        public string PhoneNumber{get;set}
        public string  Wallet{get;set}
        
        public Coustmer(string fistname ,string lastname,string email,string pin,string addres,string phoneNumber, string wallet):base(fistname ,Lastname, Email,Pin )
        {
            FirstName = fistname;
            Email = email;
            LastName = lastname;
            Pin = pin;
            Addres = addres;
            PhoneNumber = phonenumber;
            Wallet = wallet;
        }
    }
}