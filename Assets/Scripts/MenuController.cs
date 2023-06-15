using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class MenuController : MonoBehaviour
{
    public void OnButton1Clicked()
    {
        Debug.Log("Button 1 clicked!");

        // Get the party members from the PlayerManager instance
        List<PlayerCharacter> partyMembers = PlayerManager.Instance.PartyMembers;

        // Instantiate a Slime and put it in an array for the BattleEvent
        Slime slime = new Slime();
        List<EnemyMob> enemyMobs = new List<EnemyMob> { slime };

        // Create an instance of the BattleEvent and pass the characters
        BattleEvent battleEvent = new BattleEvent(partyMembers, enemyMobs);

            // Register the BattleEvent with the GameEventManager
        GameEventManager.Instance.RegisterEvent(battleEvent);

        // Trigger the events through the GameEventManager
        GameEventManager.Instance.TriggerEvents();
    }

    public void OnButton2Clicked()
    {
        Debug.Log("Button 2 clicked!");
        // Add your event code for Button 2 here
    }

    public void OnButton3Clicked()
    {
        Debug.Log("Button 3 clicked!");
        // Add your event code for Button 3 here
    }

    public void OnButton4Clicked()
    {
        Debug.Log("Button 4 clicked!");
        // Add your event code for Button 4 here
    }
}
