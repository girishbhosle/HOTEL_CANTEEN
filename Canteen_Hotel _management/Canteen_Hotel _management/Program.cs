using static Canteen_Hotel__management.Food;

namespace Canteen_Hotel__management
{
    internal class Program
    {

        Dictionary<int, List<int >> newdict = new Dictionary<int, List<int>>();
        static void Main(string[] args)
        {


            UserMenue userMenue = new UserMenue();
            userMenue.DisplayMenue();

            DataStore dataStore = new DataStore();
            dataStore.AddFoodMenue();
            dataStore.AddCustomer();
            dataStore.AddOrderData();

            HotelApplicationRuntime hotelApplicationRuntime = new HotelApplicationRuntime(userMenue, dataStore);
            hotelApplicationRuntime.HotelApplicationRuntimeMethod();



        }   
    }
}