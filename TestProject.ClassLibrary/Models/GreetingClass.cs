namespace TestProject.ClassLibrary.Models;

public class GreetingClass
{
    public int Id { get; set; }

    public string[] GreetingStrings { get; set; } = ["Hello", "world!", "How", "are", "you?"];
}