using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        class Fruit
        {
            public string name { get; set; }
            public int weight { get; set; }
            public int price { get; set; }
            public Fruit()
            {
                this.name = null;
                this.weight = 0;
                this.price = 0;
            }
            public Fruit(string name, int weight, int price)
            {
                this.name = name;
                this.weight = weight;
                this.price = price;
            }
            public Fruit(string name, int weight)
            {
                this.name = name;
                this.weight = weight;
                this.price = 0;
            }

        }
        class Shop
        {
            private List<Fruit> fruits = new List<Fruit>();

            public void addfruit(Fruit fruitadd)
            {
                fruits.Add(fruitadd);
                Console.WriteLine($"{fruitadd.name} ADD TO LIST: ");
            }
            public void removefruit(Fruit fruitremove)
            {
                fruits.Remove(fruitremove);
                Console.WriteLine($"{fruitremove.name} ADD TO LIST: ");
            }
            public void menu()
            {
                foreach (Fruit menuu in fruits)
                {
                    Console.WriteLine(menuu.name, menuu.weight, menuu.price);
                    Console.WriteLine(menuu.name, menuu.weight, menuu.price);
                    Console.WriteLine(menuu.name, menuu.weight, menuu.price);
                }
            }
        }
        class User
        {
            private string name;


        }
        static void Main(string[] args)
        {
            Console.Write("welcom the shop ^^ ");
            Console.Write(" if you are a user enter 1 and seller enter 2: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 2)
            {
                Console.Write("enter number 3 to add or enter a number 4 to remove or to price of fruit enter number 5 : ");
                int num3 = Convert.ToInt32(Console.ReadLine());
                if (num3 == 3)
                {
                    Console.Write(" name fruit adding:");
                    string nameadd = Console.ReadLine();
                    Console.Write("weight fruit adding: ");
                    int weightadd = Convert.ToInt32(Console.ReadLine());
                    Console.Write("price fruit adding: ");
                    int priceadd = Convert.ToInt32(Console.ReadLine());
                    Fruit fruitadd = new Fruit(nameadd, weightadd, priceadd);
                    Shop shop = new Shop();
                    shop.addfruit(fruitadd);
                }
                else if (num3 == 4)
                {
                    Console.Write(" name fruit remove:");
                    string nameremove = Console.ReadLine();
                    Console.Write("weight fruit remove: ");
                    int weightremove = Convert.ToInt32(Console.ReadLine());
                    Console.Write("price fruit remove: ");
                    int priceremove = Convert.ToInt32(Console.ReadLine());
                    Fruit fruitremove = new Fruit(nameremove, weightremove, priceremove);
                    Shop shop2 = new Shop();
                    shop2.addfruit(fruitremove);
                }
                if (num3 == 5)
                {
                    Console.Write(" enter name for price fruit: ");
                    string nameprice = Console.ReadLine();
                    Console.Write("enter weight fruit: ");
                    int weightprice = Convert.ToInt32(Console.ReadLine());
                    Fruit pricee = new Fruit(nameprice, weightprice);
                    Shop shop3 = new Shop();
                    shop3.


                }

            }
            if (num == 1)
            {
                Shop menuuser = new Shop();
                menuuser.menu();



            }

        }
    }
}
