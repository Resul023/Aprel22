using Aprel22.Data;
using Aprel22.Data.Entity;
using System;
using System.Linq;

namespace Aprel22
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("1-Add stadium");
                Console.WriteLine("2-Show all the stadium");
                Console.WriteLine("3-Show stadium by id");
                Console.WriteLine("4-Delete stadium by id");
                Console.WriteLine("5-Add user");
                Console.WriteLine("6-Show user");
                Console.WriteLine("Select number:");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        AddStadion();
                        break;
                    case 2:
                        ShowStadions();
                        break;
                    case 3:
                        Console.WriteLine("Write Id");
                        answer = Convert.ToInt32(Console.ReadLine());
                        ShowStadionsById(answer);
                        break;
                    case 4:
                        Console.WriteLine("Write Id");
                        answer = Convert.ToInt32(Console.ReadLine());
                        RemoveStadionById(answer);
                        break;
                    case 5:
                        AddUser();
                        break;
                    case 6:
                        ShowUser();
                        break;
                    default:
                        Console.WriteLine("You have to select only 0,1,2,3,4");
                        break;
                }

            }
        static void AddStadion() 
        {
            StadionDbContext dbContext = new StadionDbContext();
            
            string name;

            do
            {
                Console.WriteLine("Write Name");
                name = Console.ReadLine();

            } while (String.IsNullOrWhiteSpace(name));
            decimal hourlyPrice;
            string hourlyPriceTool;
            do
            {
                Console.WriteLine("Write Hourlyprice");

                hourlyPriceTool = Console.ReadLine();

            } while (!decimal.TryParse(hourlyPriceTool, out hourlyPrice));

            int capacity;
            string capacityTool;
            do
            {
                Console.WriteLine("Write Capacity");
                capacityTool = Console.ReadLine();

            } while (!int.TryParse(capacityTool, out capacity));
            Stadions stadions = new Stadions();
            stadions.Name = name;
            stadions.HourPrice = hourlyPrice;
            stadions.Capacity = capacity;
            dbContext.Add(stadions);
            dbContext.SaveChanges();
        }
        static void ShowStadions() 
        {
            StadionDbContext dbContext = new StadionDbContext();
            var data=dbContext.Stadion.ToList();
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.HourPrice} - {item.Capacity}");
            }
        } 
        static void ShowStadionsById(int id) 
            {
                StadionDbContext dbContext = new StadionDbContext();
                var data = dbContext.Stadion.FirstOrDefault(x => x.Id == id);
                Console.WriteLine(data.Id +" "+data.Name);
            }
        static void RemoveStadionById(int id) 
        {
            StadionDbContext dbContext = new StadionDbContext();
            var data = dbContext.Stadion.FirstOrDefault(x=>x.Id == id);
            dbContext.Stadion.Remove(data);
            dbContext.SaveChanges();
        }
        static void AddUser() 
        {

            string FullName;
            do
            {
                Console.WriteLine("Write Name");
                FullName = Console.ReadLine();

            } while (String.IsNullOrWhiteSpace(FullName));

            string email;

            do
            {
                Console.WriteLine("Write Email");
                email = Console.ReadLine();

            } while (String.IsNullOrWhiteSpace(email));
            Users users = new Users();
            users.Name = FullName;
            users.Email = email;
            StadionDbContext dbContext = new StadionDbContext();
            dbContext.User.Add(users);
            dbContext.SaveChanges();
        }

        static void ShowUser() 
        {
            StadionDbContext dbContext = new StadionDbContext();
            var data=dbContext.User.ToList();
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Email}");
            }
        }
        static void AddReservation() 
        {
            StadionDbContext dbContext = new StadionDbContext();
            Reservations reservations = new Reservations();
            reservations.

        }
    }
    
}
