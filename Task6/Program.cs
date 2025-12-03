namespace Task6
{
    internal class Program
    {
        private static void Main()
        {
            var bookings = new List<Booking>
            {
                new Booking { CustomerName = "Alok",  Destination = "Kathmandu",     Price = 12000, DurationInDay = 5, IsInternational = false },
                new Booking { CustomerName = "Danisha", Destination = "Paris",       Price = 85000, DurationInDay = 8, IsInternational = true  },
                new Booking { CustomerName = "Bibej", Destination = "Kathmandu",   Price =  9000, DurationInDay = 3, IsInternational = false },
                new Booking { CustomerName = "Nehal", Destination = "Dubai",       Price = 45000, DurationInDay = 6, IsInternational = true  },
                new Booking { CustomerName = "Rahul", Destination = "Itahari",     Price = 11000, DurationInDay = 5, IsInternational = false },
                new Booking { CustomerName = "Sita",   Destination = "Kerala",      Price = 25000, DurationInDay = 7, IsInternational = true  }
            };


            var summary = bookings
                .Where(b => b.Price > 10_000 && b.DurationInDay > 4)
                .Select(b => new
                {
                    b.CustomerName,
                    b.Destination,
                    Category = b.IsInternational ? "International" : "Domestic",
                    b.Price
                })
                .OrderBy(x => x.Category)
                .ThenBy(x => x.Price);

            // 4. Display
            Console.WriteLine("Filtered & Sorted Tour Summary");

            foreach (var item in summary)
            {
                Console.WriteLine($"{item.CustomerName,-10} | {item.Destination,-12} | {item.Category,-13} | Rs.{item.Price}");
            }


            Console.ReadLine();
        }
    }


    internal class Booking
    {
        public string CustomerName { get; set; } = null!;
        public string Destination { get; set; } = null!;
        public decimal Price { get; set; }
        public int DurationInDay { get; set; }
        public bool IsInternational { get; set; }
    }
}
