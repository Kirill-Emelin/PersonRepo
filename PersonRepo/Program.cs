namespace PersonRepo
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public Person(string name, string gender)
        {
            Name = name;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{Name}({Gender})";
        }
    }

    public class Program
    {
        public static void Main()
        {
            List<Person> people = new List<Person>
            {
            new Person("Алиса", "женщина"),
            new Person("Сергей", "Мужчина"),
            new Person("Яна", "женщина"),
            new Person("Давид", "Мужчина"),
            new Person("Ева", "женщина"),
            new Person("Максим", "Мужчина"),
            new Person("Диана", "женщина"),
            new Person("Генри", "Мужчина"),
            };

            Console.WriteLine("Выберите критерий сортировки:");
            Console.WriteLine("1 - По имени");
            Console.WriteLine("2 - По полу");
            int choice = int.Parse(Console.ReadLine());

            List<Person> sortedPeople;
            switch (choice)
            {
                case 1:
                    sortedPeople = people.OrderBy(p => p.Name).ToList();
                    break;
                case 2:
                    sortedPeople = people.OrderBy(p => p.Gender).ToList();
                    break;
                default:
                    Console.WriteLine("Неправильный выбор, сортировка не выполнена.");
                    return;
            }

            Console.WriteLine("Отсортированный список:");
            PrintPeopleList(sortedPeople);
        }

        public static void PrintPeopleList(List<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}

