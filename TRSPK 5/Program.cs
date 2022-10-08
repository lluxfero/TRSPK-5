Days Weekends = Days.Saturday | Days.Sunday; // 01100000
Console.WriteLine($"===ИЛИ===\n{Weekends}");
Days a = (Days)5; // 5 = 00000101
Console.WriteLine($"{a}\n");


Days IsSaturdayAtWeekends = Weekends & Days.Saturday; // 01100000 & 00100000 операция смещения И
if (IsSaturdayAtWeekends == Days.Saturday) Console.WriteLine($"===операция смещения И===\n{Days.Saturday} is weekend\n");

Weekends = Weekends ^ Days.Saturday;
Console.WriteLine($"===XOR===\n{Weekends}\n");

Weekends = Days.Saturday | Days.Sunday;
string s1 = Weekends.ToString();
Console.WriteLine($"===ToString===\n{s1}\n");

Colors orange = (Colors)Enum.Parse(typeof(Colors), "Red, Yellow");
Console.WriteLine("===Parse===\nThe orange value {0:D} has the combined entries of {0}", orange);

[Flags]
public enum Days
{
    None = 0,
    Monday = 1, // 00000001
    Tuesday = 2, // 00000010
    Wednesday = 4, // 00000100
    Thursday = 8, // 00001000
    Friday = 16, // 00010000
    Saturday = 32, // 00100000
    Sunday = 64 // 01000000
}

[Flags]
enum Colors 
{ 
    Red = 1, 
    Green = 2, 
    Blue = 4, 
    Yellow = 8 
};

