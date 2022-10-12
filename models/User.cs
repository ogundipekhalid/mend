namespace FDMS.models
{
    public class User
    {
        public string FirstName{get; set;}
        public string Email{get;set}
        public string LastName{get;set}
        public int Pin{get;set;}

        public user(string fistName ,string lastName,string email,string pin)
        {
            FirstName = fistName;
            Email = email;
            LastName = lastName;
            Pin = pin;
        }



    }
}