public class Item
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    // Additional properties or fields as needed

    public Item(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Use(PlayerCharacter target)
    {
        // Implement the item's use logic here
    }
}
