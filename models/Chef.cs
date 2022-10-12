namespace FDMS.models
{
    public class Chef:User
    {
        public string   Id{get; set;}
        public string  Post{get;set}
        public string  Supervision{get;set}

        public Chef(string fistName ,string lastName,string email,string pin ,string Id, string Post, string supervision):base(fistname ,lastname,email,Pin )
        {
            FirstName = fistName;
            Email = email;
            LastName = lastName;
            Pin = pin;
            Id = id;
            Post = post;
            Supervision = supervision;
        }

    }
}