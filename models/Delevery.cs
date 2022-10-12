namespace FDMS.models
{
    public class Delevery:User
    {
        public string HomeAddres;
        public string StoreAddress;
        public string PhoneNuberDelevery;

        public Delevery(string fistName ,string lastName,string email,string pin,string homehddres,string storeaddress,string phonenuberdelevery):base(fistName,lastName,email,pin)
        {
            FirstName = fistName;
            Email = email;
            LastName = lastName;
            Pin = pin;
            HomeAddres =homeaddres;
            StoreAddress = storeaddress;
            PhoneNuberDelevery = phonenuberdelevery;
        }
    }
}