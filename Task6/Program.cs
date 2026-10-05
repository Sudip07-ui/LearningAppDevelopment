List<string> fruits = new List<string>
        {
            "Papaya",
            "Orange",
            "Strawberry"
        };
fruits.Add("Apple");
fruits.Remove("Papaya");
Console.WriteLine("Fruits:");

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Papaya" },
            { 2, "Orange" },
            { 3, "Strawberry" },
        };
fruitDictionary.Add(4, "Apple");
Console.WriteLine("\nFruit Dictionary:");

foreach (KeyValuePair<int, string> item in fruitDictionary)
{
            Console.WriteLine("ID: " + item.Key + ", Fruit: " + item.Value);
}
