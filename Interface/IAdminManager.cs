using FDMS.models;
namespace FDMS.Interface
{
    public interface IAdminManager
    {
        public bool ICreateedFood(string fistName,string lastName,string email,string pin);
        public void IUpdateFood(string fistName,string lastName,string post);
        public void IDeletfood(Admin admin);
        public Admin IGetFood(string name);
        public Admin L  
       
    }
}