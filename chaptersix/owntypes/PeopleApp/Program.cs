using System.Collections;
using System.Collections.Generic;
using Packt.Shared;

Person harry = new Person { Name = "Harry", DateOfBirth = new DateTime(1980, 12, 31) };
harry.WriteToConsole();

Hashtable lookupObject = new Hashtable();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: 4, value: "Delta");
lookupObject.Add(key: harry, value: "Delta");

int key = 2;

WriteLine($"key {key} maps to {lookupObject[key]}");
WriteLine($"Key {harry} maps to {lookupObject[harry]}");

key = 3;
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
WriteLine($"key {key} maps to {lookupIntString[key]}");

harry.Shout += Harry_Shout;

harry.Poke();
harry.Poke();
harry.Poke();