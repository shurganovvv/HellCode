Console.WriteLine("Вы кто такие?");
string username = Console.ReadLine();
if (username.ToLower() == "карлсон")
    {
        Console.Write("Карлсончик, дорогой!");
    }
    else {
        Console.Write("Я Вас, ");
        Console.Write(username);
        Console.WriteLine(", не знаю.");
    }
