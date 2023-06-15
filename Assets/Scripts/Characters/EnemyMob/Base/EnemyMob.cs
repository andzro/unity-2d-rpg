public class EnemyMob : CharacterStats
{
    public EnemyType MobType { get; set; }

    public EnemyMob(string name, int maxHealth, int maxMana, int attackPower, int defense, int speed, EnemyType mobType)
        : base(name, maxHealth, maxMana, attackPower, defense, speed)
    {
        MobType = mobType;
    }

    public enum EnemyType
    {
        Normal,
        Boss,
        Elite,
        // Add more categories as needed
    }
    // Additional methods specific to enemy mobs
    // ...
}
