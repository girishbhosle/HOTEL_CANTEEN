using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Canteen_Hotel__management
{
    public class Hotel
    {

    }
    public class Customer
    {
        private string _Name;
        private string _City;
        private long _PhoneNo;
        private string _CustomerId;

        public string name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        public string city
        {
            set { _City = value; }
            get { return _City; }
        }
        public long phoneNo
        {
            set { _PhoneNo = value; }
            get { return _PhoneNo; }
        }
        public string customerId
        {
            set { _CustomerId = value; }
            get { return _CustomerId; }
        }

        public Customer(string name, string city, long pnNo, string custId)
        {
            _Name = name;
            _City = city;
            _PhoneNo = pnNo;
            _CustomerId = custId;
        }


    }

    public class Food
    {
        private int _id;
        private string _FoofName;
        private double _Price;
        private double _GST;
        private double _Quantity;
        private bool _Avalibility;

        public string foodName
        {
            set { _FoofName = value; }
            get { return _FoofName; }
        }
        public double Price
        {
            set { _Price = value; }
            get { return _Price; }
        }
        public double GST
        {
            set { _GST = value; }
            get { return _GST; }
        }
        public double Quantity
        {
            set { _Quantity = value; }
            get { return _Quantity; }
        }
        public bool Avalibility
        {
            set { _Avalibility = value; }
            get { return _Avalibility; }
        }
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }

        public Food(int id, string foodname, double price, double gst, double auantity, bool avaloibility)
        {
            _id = id;
            _FoofName = foodname;
            _Price = price;
            _GST = gst;
            _Quantity = auantity;
            _Avalibility = avaloibility;
        }

        public class OrderiteamNumbers
        {
            public string customerid;
            public List<int> arrays;

            public OrderiteamNumbers(string cistomeride, List<int> arrays1)
            {
                this.arrays = arrays1;
                this.customerid = cistomeride;
            }
        }
        public class DataStore
        {
            List<Food> foodList = new List<Food>();
            List<Customer> custList = new List<Customer>();
            // Dictionary<string, Array> orderNumberData = new Dictionary<string, Array>();
            Dictionary<string, List<int>> orderNumberList = new Dictionary<string, List<int>>();
            public void AddOrderData(string st, List<int> arr1)
            {
                orderNumberList.Add(st,arr1);
            }
            public void AddOrderData()
            {
                DataStore dataStore = new DataStore();
                List<int> arr1 = new List<int> { 1, 2, 3, };
                orderNumberList.Add("Girish93", arr1);
            }
            public void ShowOrderIdWithData()
            {
                foreach (var v in orderNumberList)
                {
                    Console.WriteLine(v.Key + "   "+v.Value);
                }
            }

            public List<Food> GetAllFoodData()
            {
                List<Food> newFoodList = new List<Food>();
                foreach (Food food in foodList)
                {
                    newFoodList.Add(food);
                }
                return newFoodList;
            }
            public void AddCustomer()
            {
                Customer c1 = new Customer("Girish", "Hyde", 9359189063, "Girish93");
                Customer c2 = new Customer("John", "USA", 9545454545, "John95");
                custList.Add(c1);
                custList.Add(c2);
            }

            public List<Customer> GetAllCustomerData()
            {
                List<Customer> cust = new List<Customer>();
                foreach (Customer c in custList)
                {
                    cust.Add(c);
                }
                return cust;
            }
            public string  AddNewCustomer()
            {
                Console.WriteLine("Enter the name of customer ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the city of customer ");
                string city = Console.ReadLine();

                long phno;
            BB:
                try
                {
                    Console.WriteLine("Enter the phone number of customer ");
                    phno = long.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    goto BB;
                }
                long count = phno.ToString().Length;
                Console.WriteLine(count);
                long div = 1;
                for (int i = 0; i < count - 2; i++)
                {
                    div = div * 10;
                }


                long num = phno / div;
                string st = name + num;
                //Console.WriteLine("Enter the cistid of customer ");
                //string id = Console.ReadLine();

                Customer c1 = new Customer(name, city, phno, st);
                custList.Add(c1);
                return st;
            }


            public List<Customer> ShowCustomer()
            {
                List<Customer> cust = new List<Customer>();
                foreach (Customer c in custList)
                {
                    cust.Add(c);
                }
                return cust;
            }

            public void OrderIteams(params int[] arr)
            {


            }



            public void AddFoodMenue()
            {
                Food f1 = new Food(1, "Mutton Biryani", 120, 0.05, 2, true);
                Food f2 = new Food(2, "Chiken Biryani", 100, 0.05, 2, true);
                Food f3 = new Food(3, "Paneer Masala ", 100, 0.07, 10, true);
                Food f4 = new Food(4, "Paneer Tika   ", 120, 0.07, 10, true);
                Food f5 = new Food(5, "Veg Thali     ", 200, 0.00, 20, true);
                Food f6 = new Food(6, "Froot Juice   ", 50, 0.00, 20, true);
                Food f7 = new Food(7, "Jawar Roti    ", 20, 0.00, 50, true);
                Food f8 = new Food(8, "Tandoor Roti  ", 25, 0.00, 50, true);
                Food f9 = new Food(9, "Clod Drink    ", 20, 0.00, 110, true);
                Food f10 = new Food(10, "Dal           ", 50, 0.00, 10, true);
                Food f11 = new Food(11, "Fried Rice    ", 70, 0.00, 10, false);

                foodList.Add(f1);
                foodList.Add(f2);
                foodList.Add(f3);
                foodList.Add(f4);
                foodList.Add(f5);
                foodList.Add(f6);
                foodList.Add(f7);
                foodList.Add(f8);
                foodList.Add(f9);
                foodList.Add(f10);
                foodList.Add(f11);

            }
            public void DisplayMenue()
            {
                foreach (var v in foodList)
                {
                    if (v.Quantity > 0)
                    {
                        v.Avalibility = true;
                    }
                }
                Console.WriteLine(" id         Dish Name       Price         Quantity        Avalibility");
                Console.WriteLine("");
                foreach (var food in foodList)
                {
                    {
                        Console.WriteLine(food.id + "   " + food.foodName + "           " + food.Price + "            " + food.Quantity + "          " + food.Avalibility);
                    }
                }
            }

        }

        public class HotelApplicationRuntime
        {

            private UserMenue usermenue;
            private DataStore dataStore;

            public HotelApplicationRuntime(UserMenue usermenue, DataStore dataStore)
            {
                this.usermenue = usermenue;
                this.dataStore = dataStore;
            }

            public void HotelApplicationRuntimeMethod()
            {


                 aaa:
                 XXX:
                Console.WriteLine("Enter the number depends on requriment ");
                int number = int.Parse(Console.ReadLine());


                if (number > 0 && number < 6)
                {

                    switch (number)
                    {
                        case 1:
                            Console.WriteLine(" Showing the hotel menue  ");
                            Console.WriteLine("  ");
                            dataStore.DisplayMenue();
                            Console.WriteLine("");

                            break;
                        case 2:
                            List<int> listInt = new List<int>();
                            List<int >newList = new List<int>();
                            Console.WriteLine(" ");
                            Console.WriteLine(" Enter the Food iteams number you want to eat & last press ZERO (0) ");
                        ppp:
                        p1:
                            int num = int.Parse(Console.ReadLine());

                            if (num > 0 && num < 12)
                            {
                                listInt.Add(num);
                                goto ppp;
                            }
                            if (num == 0)
                            {
                                goto ppp1;
                            }
                            else
                            {
                                Console.WriteLine("Enter the valid iteam ");
                                goto p1;
                            }
                            Console.WriteLine(" ");

                        ppp1:
                            Console.WriteLine("Finish");

                        top:
                        top1:
                            Console.WriteLine(" You are the OLD customer in canteer ??????? ");
                            Console.WriteLine("  type  yes   otherwise   type   no ");
                            bool customerStatus;
                            string opinion = Console.ReadLine();
                            if (opinion == "yes" || opinion == "YES")
                            {
                                Console.WriteLine("Enter the customer name ");
                                string name1 = Console.ReadLine();
                                bool name = false;
                                bool phno;
                                long ph;
                                aa:
                                try
                                {
                                    Console.WriteLine("Enter the customer mobile number  of 10 digits ");
                                    ph = long.Parse(Console.ReadLine());
                                    phno = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    goto aa;
                                }
                                long ph1 = ph;
                                List<Customer> custlist = dataStore.GetAllCustomerData();

                                foreach (Customer c2 in custlist)
                                {
                                    if (c2.name == name1)
                                    {
                                        name = true;
                                    }
                                    if (c2.phoneNo == ph)
                                    {
                                        phno = true;
                                    }
                                }
                                if (name == true && phno == true)
                                {
                                    Console.WriteLine(" You are the old customre of our canteen   ");
                                    Console.WriteLine("  You are getting 3 % discount of Bill");
                                    customerStatus = true;
                                    List<Customer> custlist1 = dataStore.GetAllCustomerData();
                                    string? name3 = null;
                                    foreach (Customer c2 in custlist)
                                    {
                                        if(c2.name== name1)
                                        {
                                            name3 = c2.customerId;
                                        }
                                    }


                                    dataStore.AddOrderData(name3, listInt);

                                }
                                else
                                {
                                    Console.WriteLine("  Provided informtion in rong ");
                                    goto top;
                                }
                            }
                            else if (opinion == "no" || opinion == "NO")
                            {
                               string name = dataStore.AddNewCustomer();

                                dataStore.AddOrderData(name, listInt);
                                customerStatus = false;

                                Console.WriteLine(" You are the NEW customer of our canteen   ");
                                Console.WriteLine("  You are getting 1 % discount on Bill");
                            }
                            else
                            {
                                goto top1;
                            }
                            double TotalBill = 0;
                            double d;
                            List<Food> allFoodList = dataStore.GetAllFoodData();
                            //for (int i = 0; i < allFoodList.Count; i++)
                            //{
                            //    Console.WriteLine(allFoodList[i].id);
                            //}
                            //Console.WriteLine("_____________________________");
                            //for (int i = 0; i < listInt.Count; i++)
                            //{
                            //    Console.WriteLine(listInt[i]);
                            //}


                            for (int i = 0; i < listInt.Count; i++)
                            {
                                for (int j = 0; j < allFoodList.Count; j++)
                                {

                                    if (listInt[i] == allFoodList[j].id && allFoodList[j].Quantity > 0)
                                    {
                                        TotalBill += allFoodList[j].Price + (allFoodList[j].Price * (allFoodList[i].GST));
                                        allFoodList[j].Quantity -= 1;

                                        if (allFoodList[j].Quantity == 0)
                                        {
                                            allFoodList[j].Avalibility = false;
                                        }
                                        int p = allFoodList[j].id;
                                        newList.Add(p);
                                    }
                                    else if (allFoodList[j].Quantity == 0)
                                    {
                                        allFoodList[j].Avalibility = false;
                                        Console.WriteLine(allFoodList[j].foodName + " is finished iteam ");
                                    }
                                }
                            }
                            if (customerStatus = true)
                            {
                                double finalbill = TotalBill - (TotalBill * 0.03);
                                Console.WriteLine("TotalBill    =  " + finalbill);
                            }
                            else
                            {
                                double finalbill = TotalBill - (TotalBill * 0.01);
                                Console.WriteLine("TotalBill    =  " + finalbill);
                            }

                            // double TotalBill = TotalBill -();
                            Console.WriteLine("");


                            break;
                        case 3:
                            Console.WriteLine();
                            dataStore.ShowOrderIdWithData();


                            break;
                        case 4:
                            Console.WriteLine(" ");
                            Console.WriteLine(" Showing the customer names   ");
                            Console.WriteLine(" ");


                            List<Customer> c = dataStore.ShowCustomer();

                            Console.WriteLine("Customer Name            CustomerId");
                            Console.WriteLine("");
                            foreach (Customer c1 in c)
                            {
                                Console.WriteLine(c1.name + "               " + c1.customerId);
                            }


                            Console.WriteLine("");

                            break;
                        case 5:
                            Console.WriteLine("Thx for using the hotel application ");
                            return;

                            break;
                    }
                    goto aaa;
                }
                else
                {
                    Console.WriteLine(" Plz enter the proper input to the system ");
                    goto XXX;
                }





            }


        }

    }
        public class Action
        {
            private int _ActionId;
            private string _ActionName;

            public int ActionId
            {
                set { _ActionId = value; }
                get { return _ActionId; }
            }
            public string ActionName
            {
                set { _ActionName = value; }
                get { return _ActionName; }
            }
            public Action(int _ActionId)
            {
                this.ActionId = _ActionId;
            }
            public Action(int _ActionId, string name)
            {
                this._ActionId = _ActionId;
                this._ActionName = name;
            }
        }


        public class UserMenue
        {
            public List<Action> action = new List<Action>();
            public UserMenue()
            {
                init();
            }

            public void init()
            {
                Action a1 = new Action(1, " Hotel menu ");
                Action a2 = new Action(2, " Order the food iteams ");
                Action a3 = new Action(3, " Total orders ");
                Action a4 = new Action(4, " Customer Membership ");
                Action a5 = new Action(5, " Exit the application ");

                action.Add(a1);
                action.Add(a2);
                action.Add(a3);
                action.Add(a4);
                action.Add(a5);
            }
            public void DisplayMenue()
            {
                Console.WriteLine("Welcome to the  GRAND hotel ");
                foreach (Action a in action)
                {
                    Console.WriteLine(a.ActionId + "    " + a.ActionName);
                }
            }





        }
    
}
