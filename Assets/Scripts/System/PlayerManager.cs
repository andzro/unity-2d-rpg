using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Singleton instance
    public static PlayerManager Instance { get; private set; }

    // Player data
    public int Gold { get; set; }
    public List<PlayerCharacter> PartyMembers { get; private set; }
    public List<PlayerCharacter> ReservedMembers { get; private set; }
    public List<Item> Items { get; private set; }

    private void Awake()
    {
        // Create a singleton instance
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        // Initialize player data
        Gold = 0;
        PartyMembers = new List<PlayerCharacter>();
        ReservedMembers = new List<PlayerCharacter>();
        Items = new List<Item>();

        // Add Hikari as the first party member
        Hikari hikari = new Hikari();
        PartyMembers.Add(hikari);
    }

    // Add methods to manage player data as needed
    // ...
}
