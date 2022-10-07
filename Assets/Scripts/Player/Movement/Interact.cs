using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{

    //Grab GameObjects
    public GameObject currentPortal;
    public GameObject currentSpawn;

    // Update is called once per frame
    // Press E while standing on portal to activate.
    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            if (currentPortal != null)
            {
                transform.position = currentPortal.GetComponent<Portals>().GetDestination().position;
            }
        }

    }

    //get position of connected portal when standing on the portals hitbox
    //check what checkpoint you hit next
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Portal"))
        {
            currentPortal = collision.gameObject;
        }

        if (collision.CompareTag("SpawnPoint"))
        {
            currentSpawn = collision.gameObject;
        }

    }

    //forget position of connected portals when leaving the portals hitbox
    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Portal"))
        {
            currentPortal = null;
        }
    }
}