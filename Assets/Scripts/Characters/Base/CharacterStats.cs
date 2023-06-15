public class CharacterStats
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Mana { get; set; }
    public int MaxMana { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }
    public int Speed { get; set; }

    public CharacterStats(string name, int maxHealth, int maxMana, int attackPower, int defense, int speed)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        MaxMana = maxMana;
        Mana = maxMana;
        AttackPower = attackPower;
        Defense = defense;
        Speed = speed;
    }
}
