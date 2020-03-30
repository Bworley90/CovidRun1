using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    private Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void StartButtonPressed()
    {
        anim.SetTrigger("startPressed");
    }

    public void SelectedNumberOfPlayers()
    {
        anim.SetTrigger("playersSelected");
    }

    public void LoadTheNextScene(int numberOfPlayers)
    {
        GameManager.NumberOfPlayers = numberOfPlayers;
        SceneManager.LoadScene(1);
    }
}
