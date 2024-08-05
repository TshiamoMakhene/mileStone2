namespace mileStone2
{
    internal class Program
    {// The type of media the user is going to rent.
        /*
        enum MediaType
        {
            VHS = 1,
            DVD,
            CD
        }
        //The discount amount from the amount they are going to rent.
        enum DiscountType
        {
            FivePercent = 1,
            TenPercent,
            TwentyPercent,
            ThirtyFivePercent
        }
        //Rewards to the user and gives Coupons 
        enum RewardType
        {
            None = 1,
            OneFreeCoupon,
            TwoFreeCoupon,
            FourFreeCoupon,
            EightFreeCoupon
        }
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Customer customer = GetCustomerDetails();

                List<Media> cart = new List<Media>();
                DiscountType discount = DiscountType.;
                RewardType reward = RewardType.None;

                while (true)
                {
                    Console.WriteLine("Welcvome valued customer. PLease select an option:");
                    Console.WriteLine("1. Order Media");
                    Console.WriteLine("2. Apply Discount");
                    Console.WriteLine("3. Apply Reward");
                    Console.WriteLine("4. Checkout ");
                    Console.WriteLine("5. Exit");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            OrderMedia(cart);
                            break;
                        case 2:
                            discount = ApplyDiscount();
                            break;
                        case 3:
                            reward = ApplyReward();
                            break;
                        case 4:
                            Checkout(cart, discount, reward);
                            cart.Clear();
                            discount = DiscountType.None;
                            reward = RewardType.None;
                            break;
                        case 5:
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid.");
                            break;

                    }
                    if (!running)
                        break;
                }
            }
        }
        static CustomErrorsModes GetCustomerDetails()
        {
            Console.Clear();

            Console.WriteLine("Enter customer details.");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            return new Customer(name, email, phone);
        }
        static void OrderMedia(List<Media> cart)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Order Media:");
                Console.WriteLine("1. VHS (R125.00)");
                Console.WriteLine("2. DVD (R75.00)");
                Console.WriteLine("3. CD (R50.00)");
                Console.WriteLine("4. Return");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 4)
                    break;

                MediaType mediaType = (MediaType)(choice);
                Console.Write("Enter the quantity: ");

                int quantity = int.Parse(Console.ReadLine());

                cart.Add(new Media(mediaType, quantity));
            }
        }
        static DiscountType ApplyDiscount()
        {
            Console.Clear();

            Console.WriteLine("Apply Discount");

            Console.WriteLine("1. None");
            Console.WriteLine("2. 5% discount");
            Console.WriteLine("3. 10% discount");
            Console.WriteLine("4. 20% discount");
            Console.WriteLine("5. 35% discount");

            int choice = int.Parse(Console.ReadLine());

            return (DiscountType)(choice);
        }
        static RewardType ApplyReward()
        {
            Console.Clear();
            Console.WriteLine("Apply Reward");
            Console.WriteLine("1. None");
            Console.WriteLine("2. 1 free coupon");
            Console.WriteLine("3. 2 free coupons");
            Console.WriteLine("4. 4 free coupons");
            Console.WriteLine("5. 8 free coupons");

            int choice = Convert.ToInt32(Console.ReadLine());

            return (RewardType)(choice);
        }






        //view this a bit later
        static void Checkout(List<Media> cart, DiscountType discount, RewardType rewardType)
        {
            Console.Clear();

            Console.WriteLine("Checkout");

            double total = 0;

            foreach (var item in cart)
            {
                double price = item.GetPrice();
                Console.WriteLine($"{item.Quantity}x {item.Type} - ${price * item.Quantity}");

                total += price * item.Quantity;
            }
            Console.WriteLine($"Subtotal: ${total}");

            if (discount == DiscountType.FivePercent)
            {
                total *= 0.05;
                Console.WriteLine("5% discount applied");

            }
            else if (discount == DiscountType.TenPercent)
            {
                total *= 0.1;
                Console.WriteLine("10% discount applied");
            }
            else if (discount == DiscountType.TwentyPercent)
            {
                total *= 0.2;
                Console.WriteLine("20% discount applied");
            }
            else if (discount == DiscountType.ThirtyFivePercent)
            {
                total *= 0.35;
                Console.WriteLine("35% discount applied");
            }
            double cheapest = double.MaxValue;

            foreach (var item in cart)
            {
                double price = item.GetPrice();

                if (price < cheapest)
                {
                    cheapest = price;
                }
            }
            Console.WriteLine($"Total: ${total})");
            Console.WriteLine("Thank you for your patronage.");
            Console.ReadKey();
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Customer(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
    }

    //classes to get and set the media type 
    class Media
    {
        public MediaType Type { get; set; }
        public int Quantity { get; set; }

        public Media(MediaType type, int quantity)
        {
            Type = type;
            Quantity = quantity;
        }

        public double GetPrice()
        {
            return Type switch
            {
                MediaType.VHS => 125.00,
                MediaType.DVD => 75.00,
                MediaType.CD => 50.00,


            }
        }
    }
}

*/

using System;
using System.Collections.Generic;

namespace MediaRental
    {
        class Program
        {
            enum MediaType
            {
                None=1,
                VHS,
                DVD,
                CD
            }

            enum DiscountType
            {
                None = 1,
                FivePercent,
                TenPercent,
                TwentyPercent,
                ThirtyFivePercent
            }

            enum RewardType
            {
                None = 1,
                OneFreeCoupon,
                TwoFreeCoupon,
                FourFreeCoupon,
                EightFreeCoupon
            }

            static void Main(string[] args)
            {
                bool running = true;

                while (running)
                {
                    Customer customer = GetCustomerDetails();
                    List<Media> cart = new List<Media>();
                    DiscountType discount = DiscountType.None;
                    RewardType reward = RewardType.None;

                    while (true)
                    {
                        Console.WriteLine("Welcome valued customer. Please select an option:");
                        Console.WriteLine("1. Order Media");
                        Console.WriteLine("2. Apply Discount");
                        Console.WriteLine("3. Apply Reward");
                        Console.WriteLine("4. Checkout");
                        Console.WriteLine("5. Exit");

                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                OrderMedia(cart);
                                break;
                            case 2:
                                discount = ApplyDiscount();
                                break;
                            case 3:
                                reward = ApplyReward();
                                break;
                            case 4:
                                Checkout(cart, discount, reward);
                                cart.Clear();
                                discount = DiscountType.None;
                                reward = RewardType.None;
                                break;
                            case 5:
                                running = false;
                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }

                        if (!running)
                            break;
                    }
                }
            }

            static Customer GetCustomerDetails()
            {
                Console.Clear();
                Console.WriteLine("Enter customer details:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Phone: ");
                string phone = Console.ReadLine();

                return new Customer(name, email, phone);
            }

            static void OrderMedia(List<Media> cart)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Order Media:");
                    Console.WriteLine("1. VHS (R125.00)");
                    Console.WriteLine("2. DVD (R75.00)");
                    Console.WriteLine("3. CD (R50.00)");
                    Console.WriteLine("4. Return");

                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 4) break;

                    MediaType mediaType = (MediaType)choice;
                    Console.Write("Enter the quantity: ");
                    int quantity = int.Parse(Console.ReadLine());

                    cart.Add(new Media(mediaType, quantity));
                }
            }

            static DiscountType ApplyDiscount()
            {
                Console.Clear();
                Console.WriteLine("Apply Discount:");
                Console.WriteLine("1. None");
                Console.WriteLine("2. 5% discount");
                Console.WriteLine("3. 10% discount");
                Console.WriteLine("4. 20% discount");
                Console.WriteLine("5. 35% discount");

                int choice = int.Parse(Console.ReadLine());
                return (DiscountType)choice;
            }

            static RewardType ApplyReward()
            {
                Console.Clear();
                Console.WriteLine("Apply Reward:");
                Console.WriteLine("1. None");
                Console.WriteLine("2. 1 free coupon");
                Console.WriteLine("3. 2 free coupons");
                Console.WriteLine("4. 4 free coupons");
                Console.WriteLine("5. 8 free coupons");

                int choice = int.Parse(Console.ReadLine());
                return (RewardType)choice;
            }

            static void Checkout(List<Media> cart, DiscountType discount, RewardType rewardType)
            {
                Console.Clear();
                Console.WriteLine("Checkout");
                double total = 0;

                foreach (var item in cart)
                {
                    double price = item.GetPrice();
                    Console.WriteLine($"{item.Quantity}x {item.Type} - R{price * item.Quantity}");
                    total += price * item.Quantity;
                }

                Console.WriteLine($"Subtotal: R{total}");

                double discountPercentage = discount switch
                {
                    DiscountType.FivePercent => 0.05,
                    DiscountType.TenPercent => 0.10,
                    DiscountType.TwentyPercent => 0.20,
                    DiscountType.ThirtyFivePercent => 0.35,
                    _ => 0.0
                };

                total *= (1 - discountPercentage);
                Console.WriteLine($"{(int)(discountPercentage * 100)}% discount applied");
                Console.WriteLine($"Total: R{total}");
                Console.WriteLine("Thank you for your patronage.");
                Console.ReadKey();
            }
        }

        class Customer
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }

            public Customer(string name, string email, string phone)
            {
                Name = name;
                Email = email;
                Phone = phone;
            }
        }

        class Media
        {
            public MediaType Type { get; set; }
            public int Quantity { get; set; }

            public Media(MediaType type, int quantity)
            {
                Type = type;
                Quantity = quantity;
            }

            public double GetPrice()
            {
                return Type switch
                {
                    MediaType.VHS => 125.00,
                    MediaType.DVD => 75.00,
                    MediaType.CD => 50.00,

                };
            }
        }
    }
}
