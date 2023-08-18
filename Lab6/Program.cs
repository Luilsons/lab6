using System;

class Character
{
    private string name;
    private int maxHp;
    private int presentHp;
    private int damage;
    private string classType;

    public Character(string name, int maxHp, int damage, string classType)
    {
        this.name = name;
        this.maxHp = maxHp;
        this.presentHp = maxHp;
        this.damage = damage;
        this.classType = classType;
    }

    public void heal(int amt)
    {
        this.presentHp = Math.Min(this.presentHp + amt, this.maxHp);
    }

    public void takeDamage(int amt)
    {
        this.presentHp = Math.Max(this.presentHp - amt, -1);
    }

    public int getDamage()
    {
        return this.damage;
    }

    public int getPresentHp()
    {
        return this.presentHp;
    }

    public void show()
    {
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Class: " + this.classType);
        Console.WriteLine("Max HP: " + this.maxHp);
        Console.WriteLine("Present HP: " + this.presentHp);
        Console.WriteLine("Damage: " + this.damage);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Asking the user for information 
        Console.WriteLine("Enter the character's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the character's class:");
        string classType = Console.ReadLine();

        Console.WriteLine("Enter the character's max HP:");
        int maxHp = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the character's damage:");
        int damage = int.Parse(Console.ReadLine());

        // Creating character
        Character souLuilson = new Character(name, maxHp, damage, classType);

        // Displaying the character information using the show method
        Console.WriteLine("\nCharacter Info:");
        souLuilson.show();

        // Making the character take some damage
        Console.WriteLine("\nTaking damage...");
        souLuilson.takeDamage(10);

        // Displaying the character's information again
        Console.WriteLine("\nCharacter Info:");
        souLuilson.show();

        // Healing the character
        Console.WriteLine("\nHealing...");
        souLuilson.heal(5);

        // Displaying the character's information again
        Console.WriteLine("\nCharacter Info:");
        souLuilson.show();
        Console.ReadKey();
    }
}