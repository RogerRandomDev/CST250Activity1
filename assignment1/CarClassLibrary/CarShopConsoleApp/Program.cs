using CarClassLibrary;

namespace CarShopConsoleApp;
internal class Program
{
    static Store CarStore = new Store();
    private static void Main(string[] args)
    {
        Console.Out.WriteLine("" +
            "Welcome to the car store, first you must create some cars and put them into the store inventory. Then you may add cars to the cart. finally you may checkout, which will calculate your total bill.");
        int action = chooseAction();
        while (action != 0)
        {
            try
            {
                switch (action)
                {
                    case 1:
                        Console.Out.WriteLine("You chose to add a new car to the store:");
                        string carmake = "";
                        string carmodel = "";
                        string carcolor = "";
                        int caryear = 0;
                        decimal carprice = 0;
                        Console.Out.Write("What is the car make? ford, gm, toyota etc ");
                        carmake = Console.ReadLine();
                        Console.Out.Write("what is the car model? corvette, focus, ranger ");
                        carmodel = Console.ReadLine();
                        Console.Out.Write("What is the car price? only numbers please ");
                        carprice = int.Parse(Console.ReadLine());
                        Console.Out.Write("What is the car year? numbers only ");
                        caryear = int.Parse(Console.ReadLine());
                        Console.Out.Write("What is the ar color? red, gren, black etc ");
                        carcolor = Console.ReadLine();

                        Car newcar = new Car();
                        newcar.Make = carmake;
                        newcar.Model = carmodel;
                        newcar.Price = carprice;
                        CarStore.CarList.Add(newcar);
                        printStoreInventory(CarStore);

                        break;
                    case 2:
                        printStoreInventory(CarStore);

                        int choice = 0;
                        Console.Out.Write("Which car would you like to add to the cart? (number) ");
                        choice = int.Parse(Console.ReadLine());

                        CarStore.ShoppingList.Add(CarStore.CarList[choice]);

                        printShoppingCart(CarStore);
                        break;
                    case 3:
                        printShoppingCart(CarStore);
                        Console.Out.WriteLine("Your total cost is ${0}", CarStore.checkout());
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                Console.Out.WriteLine("Invalid Input was Entered");
            }

            
            action = chooseAction();
        }
    }
    static public int chooseAction()
    {
        int choice = 0;
        Console.Out.Write("choose an action (0) quit (1) add a car (2) add item to art (3) checkout ");
        try
        {
            choice = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.Out.WriteLine("Invalid Input, Please try again");
            //just a number to be passed and allow the loop to re-run to get you back here without issues
            choice = -10000;
        }
        return choice;
    }
    static public void printStoreInventory(Store CarStore)
    {
        Console.Out.WriteLine("These are the cars in the store inventory:");
        int i = 0;
        foreach(var c in CarStore.CarList)
        {
            Console.Out.WriteLine(String.Format("Car # = {0} {1} ", i, c.Display));
            i++;
        }
    }
    static public void printShoppingCart(Store CarStore)
    {
        Console.Out.WriteLine("These are the cars in your shopping cart:");
        int i = 0;
        foreach(var c in CarStore.ShoppingList)
        {
            Console.Out.WriteLine(String.Format("Car # = {0} {1} ", i, c.Display));
            i++;
        }
    }
}