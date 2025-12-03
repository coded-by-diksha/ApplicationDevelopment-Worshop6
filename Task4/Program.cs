namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var squaredNumbers = numbers.Select(n => n * n).ToList();

            Console.WriteLine("Squared Numbers:");
            foreach (var sq in squaredNumbers)
            {
                Console.WriteLine(sq);
            }



            List<Book> books = new List<Book> //---list of book objects
            {
                new Book { Title="Java book", Price=800 },
                new Book { Title="Software Engineering", Price=1500 },
                new Book { Title="Data Structures", Price=2000 },
                new Book { Title="Story Book", Price=900 }
            };

            var premiumBooks = books.Where(b => b.Price > 1000).ToList();

            Console.WriteLine("\nBooks priced above Rs.1000:");
            foreach (var book in premiumBooks)
                Console.WriteLine($"{book.Title} - Rs.{book.Price}");



            List<Student> students = new List<Student> //---list of student objects
            {
                new Student { Name="Ananya" },
                new Student { Name="Rahul" },
                new Student { Name="Sharthak" },
                new Student { Name="Simran" },
                new Student { Name="Geeta" },
                new Student { Name="Reeta" },
                new Student { Name="Dikul" },
                new Student { Name="Radhika" },
                new Student { Name="Ocean" },
                new Student { Name="Anupa" }
            };

            var sortedStudents = students.OrderBy(s => s.Name).ToList();

            Console.WriteLine("\nStudents Sorted Alphabetically for AAA:");
            foreach (var s in sortedStudents)
            {
                Console.WriteLine(s.Name);
            }


            Console.ReadLine();
        }
    }
}
