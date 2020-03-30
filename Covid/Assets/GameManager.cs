using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int NumberOfPlayers;
    public int playerNumbers; // View number of players for testing
    public bool characterSelectOpen = false;


    // Singleton
    private void Awake() 
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    private void Update()
    {
        UpdateVariables();
    }

    private void UpdateVariables()
    {
        playerNumbers = GameManager.NumberOfPlayers; // View number of players for testing
    }




}
