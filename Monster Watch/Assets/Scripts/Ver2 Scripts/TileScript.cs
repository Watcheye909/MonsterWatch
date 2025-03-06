using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public static string tileInfo;

    public string personalTileInfo;
    public string monsterFoundHere;

    public TextMeshProUGUI text;
    public GameObject okayButton;
    public GameObject yesButton;
    public GameObject noButton;
    public GameObject dialogueBox;

    void Start()
    {
        tileInfo = "";
        if (monsterFoundHere == "" || monsterFoundHere == null)
        {
            monsterFoundHere = "NONE";
        }
    }

 
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!GameManagerScript.inUI && GameManagerScript.searchesLeft > 0)
        {
            GameManagerScript.inUI = true;
            text.text = "Command a ranger to search this area?";
            dialogueBox.SetActive(true);
            yesButton.SetActive(true);
            noButton.SetActive(true);
            tileInfo = personalTileInfo;

            Debug.Log("hello");
        }

        if (GameManagerScript.inUI && GameManagerScript.makingGuess && MicrophoneScript.makingGuess)
        {
            GameManagerScript.tileGuess = monsterFoundHere;
            GameManagerScript.madeTileGuess = true;
        }
        
    }
}
