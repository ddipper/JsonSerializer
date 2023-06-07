using System.Text.Json;
using System.Text.Json.Serialization;

Person tom = new Person("Tom", 17);
string json = JsonSerializer.Serialize<Person>(tom);
Console.WriteLine(json);
Person? person = JsonSerializer.Deserialize<Person>(json);
Console.WriteLine($"{person?.Name}, {person?.Age}");

class Person
{
    [JsonPropertyName("FirstName")]
    public string Name { get; }
    [JsonIgnore]
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

}


/*using System.Text.Json;

Person tom = new Person("Tom", 17);

var options = new JsonSerializerOptions
{
    WriteIndented = true
};

string json = JsonSerializer.Serialize<Person>(tom, options);
Console.WriteLine(json);
Person? restoredPerson = JsonSerializer.Deserialize<Person>(json);
Console.WriteLine($"{restoredPerson?.Name}, {restoredPerson?.Age}");

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}*/


/*using System.Text.Json;

using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
{
    Person tom = new Person("Tom", 17);
    await JsonSerializer.SerializeAsync<Person>(fs, tom);
    Console.WriteLine("Data has been saved to file");
}

using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
{
    Person? person = await JsonSerializer.DeserializeAsync<Person>(fs);
    Console.WriteLine($"Name: {person?.Name}, Age: {person?.Age}");
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}*/


/*using System.Text.Json;

Person tom = new Person("Tom", 17);
string json = JsonSerializer.Serialize(tom);
Console.WriteLine(json);
Person? restoredPerson = JsonSerializer.Deserialize<Person>(json);
Console.WriteLine(restoredPerson?.Name);

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}*/