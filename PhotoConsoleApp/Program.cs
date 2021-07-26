using Photoapp2;
using System;

namespace PhotoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Store s = new Store();

            Console.WriteLine("Hello! Lets Create a Photo inventory, Then you can add photos to the shopping cart. The checkout will tell you the total amount of the items in the shopping cart.");

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("You chose" + action);

                switch (action)
                {
                    //Add Item to inventory
                    case 1:

                        Console.WriteLine("You chose a new photo to add to the inventory");


                        string photoID = "";
                        string phototitle = "";
                        string photoStyle = "";
                        int photoView = 0;
                        string photoPrivacy = "";
                        int photoPrice = 0;

                        Console.WriteLine("What is the photo ID?");
                        photoID = Console.ReadLine();

                        Console.WriteLine("What is the photo title?");
                        phototitle = Console.ReadLine();

                        Console.WriteLine("What is the photo style?");
                        photoStyle = Console.ReadLine();

                        Console.WriteLine("What is the photo view?");
                        photoView = int.Parse(Console.ReadLine());

                        Console.WriteLine("What is the photo privacy?");
                        photoPrivacy = Console.ReadLine();

                        Console.WriteLine("What is the photo price?");
                        photoPrice = int.Parse(Console.ReadLine());



                        Photo newPhoto = new Photo(photoID, phototitle, photoStyle, photoView, photoPrivacy, photoPrice);
                        s.PhotoList.Add(newPhoto);

                        printinventory(s);
                        break;


                    //Add to cart
                    case 2:

                        Console.WriteLine("You Chose to add a photo to the shopping cart");
                        printinventory(s);
                        Console.WriteLine("What photo would you like to buy? (Number) ");
                        int photoChosen = int.Parse(Console.ReadLine());

                        s.ShoppingList.Add(s.PhotoList[photoChosen]);

                        printShoppingCart(s);
                        break;

                    //Checkout Items
                    case 3:
                        printShoppingCart(s);
                        Console.WriteLine("The total cost of your items are: " + s.checkout());



                        break;

                    default:
                        break;
                }




                action = chooseAction();
            }



        }

        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("Photos you have chosen to buy");
            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine("Photo # : " + i + "" + s.ShoppingList[i]);
            }
        }

        private static void printinventory(Store s)
        {
            for (int i = 0; i < s.PhotoList.Count; i++)
            {
                Console.WriteLine("Photo #: " + i + "" + s.PhotoList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new photo to inventory (2) add photo to the cart (3) go to checkout ");

            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}


