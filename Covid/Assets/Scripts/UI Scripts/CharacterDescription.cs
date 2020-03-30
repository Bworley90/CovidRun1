using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDescription : MonoBehaviour
{
    public Text charInfo;
    public string currentCharacter;

    public string oneInfo;
    public string twoInfo;
    public string threeInfo;


    private void Update()
    {
        UpdateDescription();
    }

    public void UpdateDescription()
    {
        if(currentCharacter == "one")
        {
            charInfo.text = oneInfo;
        }
        else if(currentCharacter == "two")
        {
            charInfo.text = twoInfo;
        }
        else if(currentCharacter == "three")
        {
            charInfo.text = threeInfo;
        }
    }

    public void HoverOverCharacter(string characterName)
    {
        currentCharacter = characterName;
    }




}
