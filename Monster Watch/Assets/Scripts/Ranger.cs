using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranger : MonoBehaviour
{
    private Vector3 destination;
    private Vector3 movementVector;

    public GameObject RangerReportPrompt;

    private int rangerNum;
    private bool reachedDestination;

    //Determines destination.
    void Start()
    {
        destination = MapBackground.SearchPos;
        movementVector = (new Vector3((destination.x - transform.position.x) / 2, (destination.y - transform.position.y) / 2)).normalized;
        rangerNum = MapBackground.availableRangers;
        MapBackground.availableRangers -= 1;
        reachedDestination = false;
    }


    //Moving towards the destinaion.
    void Update()
    {
        if (UIManager.inUI == false)
        {
            if (!reachedDestination)
            {
                transform.position += (movementVector / 3) * Time.deltaTime;
            }

            //When the ranger reaches the destination.
            if ((destination.x - 0.3f) < transform.position.x && (destination.x + 0.3f) > transform.position.x && (destination.y - 0.3f) < transform.position.y && (destination.y + 0.3f) > transform.position.y)
            {
                //Notify the radio buttons.
                if (rangerNum == 1 && !RadioButton.ranger1InPosition && !reachedDestination)
                {
                    RadioButton.ranger1InPosition = true;
                    reachedDestination = true;
                    
                }
                if (rangerNum == 2 && !RadioButton.ranger2InPosition && !reachedDestination)
                {
                    RadioButton.ranger2InPosition = true;
                    reachedDestination = true;

                }
                if (rangerNum == 3 && !RadioButton.ranger3InPosition && !reachedDestination)
                {
                    RadioButton.ranger3InPosition = true;
                    reachedDestination = true;
                    

                }

                //Once the button has been clicked.
                if (rangerNum == 1 && !RadioButton.ranger1InPosition && reachedDestination)
                {
                    MapBackground.availableRangers += 1;
                    Debug.Log(MapBackground.availableRangers);
                    UIManager.rangerReport = true;
                    Destroy(gameObject);
                }
                if (rangerNum == 2 && !RadioButton.ranger2InPosition && reachedDestination)
                {
                    MapBackground.availableRangers += 1;
                    Debug.Log(MapBackground.availableRangers);
                    UIManager.rangerReport = true;
                    Destroy(gameObject);
                }
                if (rangerNum == 3 && !RadioButton.ranger3InPosition && reachedDestination)
                {
                    MapBackground.availableRangers += 1;
                    Debug.Log(MapBackground.availableRangers);
                    UIManager.rangerReport = true;
                    Destroy(gameObject);
                }


            }
        }
        
    }
}
