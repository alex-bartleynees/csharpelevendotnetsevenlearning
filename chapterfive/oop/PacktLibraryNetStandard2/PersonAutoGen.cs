namespace Packt.Shared
{
    public partial class Person
    {
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        public string Greeting => $"{Name} says 'Hello!'";

        public int Age => DateTime.Today.Year - DateOfBirth.Year;

        public string? FavouriteIceCream { get; set; }

        private string? favouritePrimaryColor;

        public string? FavouritePrimaryColor
        {
            get
            {
                return favouritePrimaryColor;
            }
            set
            {
                switch (value?.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favouritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException($"{value} is not a primary color. " + "Choose from: red, green, blue.");
                }
            }
        }

        // indexers
        public Person this[int index]
        {
            get
            {
                return Children[index]; // pass the indexing value to the Children list
            }
            set
            {
                Children[index] = value;
            }
        }

        public Person this[string name]
        {
            get
            {
                return Children.Find(x => x.Name == name);
            }
            set
            {
                Person found = Children.Find(x => x.Name == name);
                if (found is not null)
                {
                    found = value;
                }
            }
        }

        private bool married = false;

        public bool Married => married;

        private Person? spouse = null;

        public Person? Spouse => spouse;

        public static void Marry(Person person1, Person person2)
        {
            person1.Marry(person2);
        }

        public void Marry(Person partner)
        {
            if (married)
            {
                return;
            }

            spouse = partner;
            married = true;
            partner.Marry(this);
        }

        public static Person Procreate(Person person1, Person person2)
        {
            if (person1.Spouse != person2)
            {
                throw new ArgumentException(
                    $"{person1.Name} and {person2.Name} are not married to each other.");
            }

            Person baby = new Person
            {
                Name = $"Baby of {person1.Name} and {person2.Name}",
                DateOfBirth = DateTime.Now
            };

            person1.Children.Add(baby);
            person2.Children.Add(baby);
            return baby;
        }

        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        public static bool operator +(Person p1, Person p2)
        {
            Marry(p1, p2);
            return p1.married && p2.married;
        }

        public static Person operator *(Person p1, Person p2)
        {
            return Procreate(p1, p2);
        }
    }
}