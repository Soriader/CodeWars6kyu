namespace CodeWars6kyu;

public interface IMarine
{
    int Damage { get; }
    int Armor { get; }
}

public class Marine : IMarine
{
    public Marine(int damage, int armor)
    {
        Damage = damage;
        Armor = armor;
    }

    public int Damage { get; }
    public int Armor { get; }
}

public class MarineWeaponUpgrade : IMarine
{
    private readonly IMarine marine;

    public MarineWeaponUpgrade(IMarine marine)
    {
        this.marine = marine;
    }

    public int Damage => marine.Damage + 1;
    public int Armor => marine.Armor;
}

public class MarineArmorUpgrade : IMarine
{
    private readonly IMarine marine;

    public MarineArmorUpgrade(IMarine marine)
    {
        this.marine = marine;
    }

    public int Damage => marine.Damage;
    public int Armor => marine.Armor + 1;
}
//https://www.codewars.com/kata/5682e545fb263ecf7b000069/train/csharp
