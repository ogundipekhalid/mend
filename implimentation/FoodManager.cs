using FDMS.interface;
using FDMS.models
namespace FDMS.implimentation
{
    public static list<food> listOfFood = new list<Food>();       //temporary databesa or emomory
    
    
    //immlimentetion of folder of interface and impimentetion it self
    public class FoodManager:IFoodManager
    {
        public  void CreateedFood(string foodName, int Price);
        {
            Random rand = new Random();
            int refno = rand.Next(100,999);

            Food food = new  Food(refno,foodName, price);
            Console.writeline($"{foodName}"created sucessfully");

        }
         public void UpdateFood(string FoodName, string newFoodName ,int Price)
         {
            food foodToUpdate.FoodName = GetFood(foodName);
            foodToUpdate.foodName =newFoodName;
            foodToUpdate.price = newprice;
            Console.writeline("food update sucessfull"); 
         }
         public void Deletfood(Food food)
         {
            foreach (var item in listOfFood)
            {
                if (item.RefNumber == refnumber )
                {
                    listOfFood.Remove(otem);
                    break;
                }
            }
            Console.writeline("remove sucecefull");
         }
         public Food GetFood(string foodname)
         {
           foreach(var item in listOfFood)
           {
                if(item.foodName ===foodName)
                {
                    return item;
                }
           }
           return null;
         }
         public Food GetFood(int  Refno)
         {
            
           foreach(var item in listOfFood)
           {
                if(item.refno === refno)
                {
                    return item;
                }
                return null;
           }
         }
    }
}