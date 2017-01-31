using UnityEngine;
using System.Collections;

public class NewGame : MonoBehaviour {

    /// <summary>
    /// This script / function starts a new game when the player clicks the "New Game" button
    /// in the main menu. It gives the player an amount of gold to start with
    /// if the player already had a saved game it will reset his inventory and stats
    /// </summary>
    public void StartNewGame()
    {
        PlayerInformation.Gold = 500;
        PlayerInformation.ClickLevel = 1;
    }
}
