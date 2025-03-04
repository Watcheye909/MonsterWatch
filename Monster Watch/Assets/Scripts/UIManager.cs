using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static bool inUI;
    public static bool rangerReport;

    public GameObject searchPrompt;
    public GameObject rangerReportPrompt;
    public GameObject Ranger;
    public GameObject Tower1;
    public GameObject Tower2;
    public GameObject Tower3;
    
    void Start()
    {
        inUI = false;
        searchPrompt.SetActive(false);
        rangerReportPrompt.SetActive(false);
        rangerReport = false;
    }
    
    //Checking if the player is using the UI.
    void Update()
    {
        if (searchPrompt.activeInHierarchy)
        {
            inUI = true;
        }
        else if (rangerReportPrompt.activeInHierarchy)
        {
            inUI = true;
        }
        else
        {
            inUI = false;
        }

        if (rangerReport)
        {
            rangerReportPrompt.SetActive(true);
        }
    }

    //Functionality for every button that says no.
    public void NoButton(GameObject prompt)
    {
        rangerReport = false;
        prompt.SetActive(false);
    }


    //Spawning the rangers
    public void SpawnRanger ()
    {
        float rand = Random.Range(0, 3);
        if (rand < 1.1f)
        {
            Instantiate(Ranger, Tower1.transform.position, Quaternion.identity);
            searchPrompt.SetActive(false);
        }
        else if (1 < rand && rand > 2.1f) 
        {
            Instantiate(Ranger, Tower2.transform.position, Quaternion.identity);
            searchPrompt.SetActive(false);
        }
        else if (rand > 2)
        {
            Instantiate(Ranger, Tower3.transform.position, Quaternion.identity);
            searchPrompt.SetActive(false);
        }

    }

}
