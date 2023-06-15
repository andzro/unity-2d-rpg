public class HealingItem : Item
{
    public int HealingAmount { get; private set; }

    public HealingItem(string name, string description, int healingAmount)
        : base(name, description)
    {
        HealingAmount = healingAmount;
    }

    public override void Use(PlayerCharacter target)
    {
        // Implement the specific healing logic here
        target.Health += HealingAmount;
    }
}
