using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public static int searchesLeft;
    public static int guessesLeft;
    public static bool makingGuess;
    public static string monsterGuess;
    public static string tileGuess;
    public static bool madeTileGuess;

    public TextMeshProUGUI text;
    public GameObject okayButton;
    public GameObject yesButton;
    public GameObject noButton;
    public GameObject dialogueBox;
    public TextMeshProUGUI searchText;
    public TextMeshProUGUI guessesText;
    public GameObject scarySpiderButton;
    public GameObject shiveringSpiderButton;
    public GameObject spinyDragon;
    public GameObject peppyDragon;
    public GameObject psychicMoth;
    public GameObject friendlyMoth;

    public static bool inUI;

    public static bool mothGuessed;
    public static bool dragonGuessed;

    void Start()
    {
        Screen.SetResolution(1920, 1080, true);
        searchesLeft = 20;
        inUI = false;
        text.text = "";
        okayButton.SetActive(false);
        yesButton.SetActive(false);
        noButton.SetActive(false);
        dialogueBox.SetActive(false);
        guessesLeft = 3;
        monsterGuess = "";
        tileGuess = "";
        madeTileGuess = false;
        scarySpiderButton.SetActive(false);
        shiveringSpiderButton.SetActive(false);
        spinyDragon.SetActive(false);
        peppyDragon.SetActive(false);
        psychicMoth.SetActive(false);
        friendlyMoth.SetActive(false);
        mothGuessed = false;
        dragonGuessed = false;
}

    
    public void YesButton ()
    {
        if (!MicrophoneScript.makingGuess)
        {
            yesButton.SetActive(false);
            noButton.SetActive(false);
            text.text = TileScript.tileInfo;
            okayButton.SetActive(true);
            searchesLeft -= 1;
        }
        else
        {
            text.text = "Select where you believe a monster is hiding.";
            yesButton.SetActive(false);
            noButton.SetActive(false);
            makingGuess = true;
        }
        
    }

    public void NoButton ()
    {
        yesButton.SetActive(false);
        noButton.SetActive(false);
        dialogueBox.SetActive(false);
        okayButton.SetActive(false);
        text.text = "";
        text.fontSize = 45;
        inUI = false;
        MicrophoneScript.makingGuess = false;  
    }


    public void MonsterButton (string monster)
    {
        scarySpiderButton.SetActive(false);
        shiveringSpiderButton.SetActive(false);
        spinyDragon.SetActive(false);
        peppyDragon.SetActive(false);
        psychicMoth.SetActive(false);
        friendlyMoth.SetActive(false);

        monsterGuess = monster;
        if (monsterGuess == tileGuess)
        {
            
            if (monsterGuess == "PSYCHIC MOTH")
            {
                mothGuessed = true;
            }
            else if (monsterGuess == "SPINY DRAGON")
            {
                dragonGuessed = true;
                Debug.Log("YAYY");
            }

            text.text = "Amazing Boss! We found the monster and safely delt with it.";
            okayButton.SetActive(true);
            MicrophoneScript.makingGuess = false;
            makingGuess = false;
            madeTileGuess = false;
            monsterGuess = "";
            tileGuess = "";

        }
        else
        {
            guessesLeft -= 1;
            text.text = "Sorry Boss, we couldn't find any monster nests there.";
            okayButton.SetActive(true);

            if (tileGuess != "NONE")
            {
                text.text = "Boss! We found the nest, but it was the wrong monster. We we're underprepared so we couldn't remove it. Try again!";
                text.fontSize = 36;
            }

            MicrophoneScript.makingGuess = false;
            makingGuess = false;
            madeTileGuess = false;
            monsterGuess = "";
            tileGuess = "";
        }
    }


    private void Update()
    {
        searchText.text = searchesLeft.ToString() + " SP";
        guessesText.text = guessesLeft.ToString() + " G";

        if (madeTileGuess == true)
        {
            MicrophoneScript.makingGuess = false;
            text.text = "Which monster is located here?";
            yesButton.SetActive(false);
            noButton.SetActive(false);
            scarySpiderButton.SetActive(true);
            shiveringSpiderButton.SetActive(true);
            spinyDragon.SetActive(true);
            peppyDragon.SetActive(true);
            psychicMoth.SetActive(true);
            friendlyMoth.SetActive(true);
        }
    }

}
