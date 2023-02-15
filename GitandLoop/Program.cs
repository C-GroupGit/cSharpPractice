//Liannys- String Array and Loop
string[] names = new string[]{"Lizette", "Brianna", "Liannys"};
foreach(string name in names){
    Console.WriteLine(name);
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


Dictionary<string, string> AnimalsList = new Dictionary<string, string>();
AnimalsList.Add("Giraffe","Mammal");
AnimalsList.Add("Flamingo","Bird");
AnimalsList.Add("Turtle","Reptile");
AnimalsList.Add("Shark","Fish");

foreach(var entry in AnimalsList) {
    Console.WriteLine($"{entry.Key} is a {entry.Value}");
}
List<string> cities = new List<string>() {"Atlanta", "Dallas", "LA", "New York City", "Boston","Chicago","Austin"};

foreach(var city in cities) {
    Console.WriteLine(city);
}