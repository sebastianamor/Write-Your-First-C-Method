/*    string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input) 
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength(); 
    ValidateZeroes(); 
    ValidateRange();

    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength() 
{
    validLength = address.Length == 4;
};

void ValidateZeroes() 
{
    foreach (string number in address) 
    {
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange() 
{
    foreach (string number in address) 
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255) 
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}*/

using System;

class FortuneTeller
{
    private static Random random = new Random();
    
    // Método principal para obtener una fortuna
    public static void tellFortune()
    {
        int luck = random.Next(100);
        DisplayFortune(luck);
    }
    
    // Método sobrecargado para usar una suerte específica
    public static void tellFortune(int luck)
    {
        DisplayFortune(luck);
    }
    
    // Método para generar suerte
    public static int GenerateLuck()
    {
        return random.Next(100);
    }
    
    // Método interno que muestra la fortuna
    private static void DisplayFortune(int luck)
    {
        string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
        string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
        string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
        string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};
        
        Console.WriteLine("A fortune teller whispers the following words:   ");
        
        string[] fortune;
        if (luck > 75)
        {
            fortune = good;
            Console.WriteLine("Your luck is HIGH today!");
        }
        else if (luck < 25)
        {
            fortune = bad;
            Console.WriteLine("Your luck is LOW today...");
        }
        else
        {
            fortune = neutral;
            Console.WriteLine("Your luck is NEUTRAL today.");
        }
        
        for (int i = 0; i < 4; i++) 
        {
            Console.WriteLine($"{text[i]} {fortune[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo 1: Generar fortuna automáticamente
        FortuneTeller.tellFortune();
        
        Console.WriteLine("\n" + new string('-', 50) + "\n");
        
        // Ejemplo 2: Usar un valor de suerte específico
        FortuneTeller.tellFortune(80); // Alta suerte
        
        Console.WriteLine("\n" + new string('-', 50) + "\n");
        
        // Ejemplo 3: Generar suerte primero y luego usarla
        int playerLuck = FortuneTeller.GenerateLuck();
        Console.WriteLine($"Tu estadística de suerte es: {playerLuck}");
        FortuneTeller.tellFortune(playerLuck);
    }
}