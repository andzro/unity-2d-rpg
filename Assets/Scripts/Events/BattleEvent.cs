using System.Collections.Generic;
using UnityEngine;

public class BattleEvent : EventBase
{
    private List<PlayerCharacter> partyMembers;
    private List<EnemyMob> enemyMobs;

    public BattleEvent(List<PlayerCharacter> partyMembers, List<EnemyMob> enemyMobs)
    {
        this.partyMembers = partyMembers;
        this.enemyMobs = enemyMobs;
    }

    public override void ExecuteEvent()
    {
        // Perform battle logic using the party members and enemy mobs

        // Example logic for displaying battle information
        Debug.Log("Battle Start!");
        foreach (PlayerCharacter partyMember in partyMembers)
        {
            Debug.Log("Party Member: " + partyMember.Name);
        }
        foreach (EnemyMob enemyMob in enemyMobs)
        {
            Debug.Log("Enemy Mob: " + enemyMob.Name);
        }
        // Example battle mechanics go here
    }
}
