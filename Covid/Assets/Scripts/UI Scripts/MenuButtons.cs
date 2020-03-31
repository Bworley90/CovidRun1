using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    private Animator anim;
    public GameObject playerOne;
    public GameObject playerTwo;
    public GameObject playerThree;



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

    public void LoadTheNextScene()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayerSelected(int playerNumber)
    {
        if (playerNumber == 1)
        {
            GameManager.instance.selectedPlayer = playerOne;
            SceneManager.LoadScene(1);
        }
        else if (playerNumber == 2)
        {
            GameManager.instance.selectedPlayer = playerTwo;
            SceneManager.LoadScene(1);
        }
        else if (playerNumber == 3)
        {
            GameManager.instance.selectedPlayer = playerThree;
            SceneManager.LoadScene(1);
        }
    }

}
