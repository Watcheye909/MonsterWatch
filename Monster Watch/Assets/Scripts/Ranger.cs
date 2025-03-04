using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranger : MonoBehaviour
{
    private Vector3 destination;
    private Vector3 movementVector;

    public GameObject RangerReportPrompt;


    //Determines destination.
    void Start()
    {
        destination = MapBackground.SearchPos;
        movementVector = (new Vector3((destination.x - transform.position.x) / 2, (destination.y - transform.position.y) / 2)).normalized;
        MapBackground.availableRangers -= 1;
    }


    //Moving towards the destinaion.
    void Update()
    {
        if (UIManager.inUI == false)
        {
            transform.position += (movementVector / 3) * Time.deltaTime;
            if ((destination.x - 0.3f) < transform.position.x && (destination.x + 0.3f) > transform.position.x && (destination.y - 0.3f) < transform.position.y && (destination.y + 0.3f) > transform.position.y)
            {
                MapBackground.availableRangers += 1;
                Debug.Log(MapBackground.availableRangers);
                UIManager.rangerReport = true;
                Destroy(gameObject);
            }
        }
        
    }
}
