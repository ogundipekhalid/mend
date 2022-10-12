//using fdms and food properties  retun object of food class and 
using FDMS.models;

namespace FDMS.Interface
{
    public interface IFoodManager
    {
        //we crate an intance of Food the Food as data type just like int string 
         public void  CreateedFood(string foodName, int Price);
         public void UpdateFood(string FoodName, string newFoodName, int newPrice);
         public void Deletfood(int refno);//deleting whole claass of intance food object
         public Food GetFood(string food);//get before deleting
         public Food GetFood(int  Refno);//the retun type of object claass of food object
    }
}