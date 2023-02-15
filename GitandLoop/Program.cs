// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


Dictionary<string, string> AnimalsList = new Dictionary<string, string>();
AnimalsList.Add("Giraffe","Mammal");
AnimalsList.Add("Flamingo","Bird");
AnimalsList.Add("Turtle","Reptile");
AnimalsList.Add("Shark","Fish");

foreach(var entry in AnimalsList) {
    Console.WriteLine($"{entry.Key} is a{entry.Value}");
}