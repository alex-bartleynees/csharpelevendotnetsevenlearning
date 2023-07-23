using Packt.Shared;

var p = new Person();
p.Name = "Bob Smith";
p.DateOfBirth = new DateTime(1965, 12, 22);
p.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
p.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

WriteLine($"{p.Name} was born on {p.DateOfBirth:dddd, d MMMM yyyy}");
WriteLine($"{p.Name}'s favorite wonder is {p.FavoriteAncientWonder}. It's integer is {(int)p.FavoriteAncientWonder}.");
WriteLine($"{p.Name}'s bucket list is {p.BucketList}. It's integer is {(int)p.BucketList}.");

var alice = new Person
{
    Name = "Alice Jones",
    DateOfBirth = new DateTime(1998, 3, 7)
};
p.Children.Add(alice);
p.Children.Add(new Person { Name = "Zoe Jones", DateOfBirth = new DateTime(2002, 11, 23) });

WriteLine($"{alice.Name} was born on {alice.DateOfBirth:dddd, d MMMM yyyy}");
WriteLine($"{p.Name} has {p.Children.Count} children.");

for (int childIndex = 0; childIndex < p.Children.Count; childIndex++)
{
    WriteLine($"> {p.Children[childIndex].Name}");
}

BankAccount.InterestRate = 0.012M; // store a shared value
var jonesAccount = new BankAccount();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C} interest.");

var gerrierAccount = new BankAccount();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance * BankAccount.InterestRate:C} interest.");

WriteLine($"{p.Name} is a {Person.Species}.");
WriteLine($"{p.Name} was born on {p.HomePlanet}.");

Person blankPerson = new Person();
WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on a {blankPerson.Instantiated:dddd}.");

Person martian = new Person("Martian", "Mars");
WriteLine($"{martian.Name} of {martian.HomePlanet} was created at {martian.Instantiated:hh:mm:ss} on a {martian.Instantiated:dddd}.");
WriteLine($"{martian.GetOrigin()}");
alice.WriteToConsole();


(string fruit, int number) fruit = p.GetFruit();
WriteLine($"{fruit.fruit}, {fruit.number} there are.");

var (name, dob, fav) = p;
WriteLine($"{name} was born on {dob:dddd, d MMMM yyyy} and favorite wonder is {fav}.");
WriteLine(p.SayHello());
WriteLine(p.SayHello("Emily"));
WriteLine(p.OptionalParameters());
WriteLine(p.OptionalParameters("Jump!", 98.5));
WriteLine(p.OptionalParameters(number: 52.7, command: "Hide!"));
WriteLine(p.OptionalParameters("Poke!", active: false));
int a = 10;
int b = 20;

WriteLine($"Before: a = {a}, b = {b}");
p.PassingParameters(a, ref b, out int c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

Person sam = new Person
{
    Name = "Sam",
    DateOfBirth = new DateTime(1972, 1, 27)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

Book book = new()
{
    Author = "Charles Dickens",
    Title = "Hard Times",
    Isbn = "1234567890",
    PageCount = 345
};

WriteLine($"{book.Title} by {book.Author}");
sam.Children.Add(new Person { Name = "Charlie" });
sam.Children.Add(new Person { Name = "Ella" });

WriteLine($"{sam.Name}'s first child is {sam[0].Name}");
WriteLine($"{sam.Name}'s second child is {sam[1].Name}");

WriteLine($"Sams child named Ella is {sam["Ella"].Age} years old.");

Person lamech = new Person
{
    Name = "Lamech",
    DateOfBirth = new DateTime(1970, 4, 3)
};

Person adah = new Person
{
    Name = "Adah",
    DateOfBirth = new DateTime(1971, 7, 8)
};

Person zillah = new Person
{
    Name = "Zillah",
    DateOfBirth = new DateTime(1972, 1, 27)
};

lamech.Marry(adah);
Person.Marry(zillah, lamech);
if (zillah + lamech)
{
    WriteLine($"{zillah.Name} is now married to {lamech.Name}.");
}
WriteLine($"{lamech.Name}'s spouse is {lamech.Spouse.Name}");
WriteLine($"{adah.Name}'s spouse is {adah.Spouse.Name}");
WriteLine($"{zillah.Name}'s spouse is {zillah.Spouse?.Name ?? "spouseless"}");

Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.DateOfBirth:dddd, d MMMM yyyy}");

Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubal-Cain";
WriteLine($"{lamech.Name} has {lamech.Children.Count} children:");
WriteLine($"{adah.Name} has {adah.Children.Count} children:");
WriteLine($"{zillah.Name} has {zillah.Children.Count} children:");

foreach (Person child in lamech.Children)
{
    WriteLine($"{child.Name}");
}