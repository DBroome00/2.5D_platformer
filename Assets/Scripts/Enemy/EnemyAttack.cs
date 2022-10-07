using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //Do damage to player if colliding with player
    private void OnCollisionEnter(Collision collision)
    {
        GameObject targetHit = collision.gameObject;
        if (targetHit.tag == "Player")
            targetHit.GetComponent<Health>().TakeDamage(1);
    }
}
