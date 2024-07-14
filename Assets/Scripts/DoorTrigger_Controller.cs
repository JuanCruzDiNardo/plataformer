using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger_Controller : MonoBehaviour
{
    public List<Door_Controller> doors;
    public bool onTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!onTrigger)
            {
                TriggerDoor();
                onTrigger = !onTrigger;
            }
            
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (onTrigger)
            {
                TriggerDoor();
                onTrigger = !onTrigger;
            }
            
        }
    }

    private void TriggerDoor()
    {
        foreach (Door_Controller door in doors)
            door.triggered = true;
    }
}
