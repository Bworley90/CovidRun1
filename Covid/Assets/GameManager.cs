using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject selectedPlayer;
    private bool loadedCharacter = false;



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

    public void SpawnPlayer()
    {
        if (!loadedCharacter && SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (selectedPlayer != null)
            {
                Instantiate(selectedPlayer);
                loadedCharacter = true;
            }
            else
            {
                print("Missing Player Selected");
                loadedCharacter = true;
            }
        }
        
        
    }
    private void Update()
    {
        SpawnPlayer();
    }

}
