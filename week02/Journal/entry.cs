using System;

public class Entry
{
    public string Date;
    public string Prompt;
    public string Response;

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }
    public string ToFileString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
         return new Entry(parts[0], parts[1], parts[2]);
    }
}
