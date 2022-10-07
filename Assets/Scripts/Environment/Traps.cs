using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    //kill the player if landing on trap
    private void OnCollisionEnter(Collision collision)
    {
        GameObject targetHit = collision.gameObject;
        if (targetHit.tag == "Player")
        targetHit.GetComponent<Health>().Die();
    }
}
