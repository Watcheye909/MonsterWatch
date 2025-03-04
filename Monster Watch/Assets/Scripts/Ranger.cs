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
        movementVector = (new Vector3(destination.x - transform.position.x, destination.y - transform.position.y)).normalized;
    }


    //Moving towards the destinaion.
    void Update()
    {
        if (UIManager.rangerReport == false)
        {
            transform.position += movementVector * Time.deltaTime;
            if ((destination.x - 0.3f) < transform.position.x && (destination.x + 0.3f) > transform.position.x && (destination.y - 0.3f) < transform.position.y && (destination.y + 0.3f) > transform.position.y)
            {
                UIManager.rangerReport = true;
                Destroy(gameObject);
            }
        }
        
    }
}
