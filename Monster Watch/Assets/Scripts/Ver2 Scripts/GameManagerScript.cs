using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public static int searchesLeft;

    public TextMeshProUGUI text;
    public GameObject okayButton;
    public GameObject yesButton;
    public GameObject noButton;
    public GameObject dialogueBox;

    public static bool inUI;

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
    }

    public void YesButton ()
    {
        yesButton.SetActive(false);
        noButton.SetActive(false);
        text.text = TileScript.tileInfo;
        okayButton.SetActive(true);
        searchesLeft -= 1;
    }

    public void NoButton ()
    {
        yesButton.SetActive(false);
        noButton.SetActive(false);
        dialogueBox.SetActive(false);
        okayButton.SetActive(false);
        text.text = "";
        inUI = false;
    }
}
