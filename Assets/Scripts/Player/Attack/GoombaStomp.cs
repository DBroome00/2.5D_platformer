using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaStomp : MonoBehaviour
{

    // grab rigidbody and create bounce variable
    public float bounce;
    public Rigidbody rb;

    //bounce on enemy if Goombastomp hitbox hit enemy
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //Destroy(other.gameObject);
            rb.velocity = new Vector2(rb.velocity.x, bounce);
        }
    }
}
