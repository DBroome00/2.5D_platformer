using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    //Health Variables
    [Header ("Health")]
    [SerializeField] public int maxHealth;
    [SerializeField] public float currentHealth;

    //Spawn Point
    [Header("Spawn Points")]
    [SerializeField] public Transform spawnPoint;

    //Set initial spawn point and health
    private void Awake()
    {
        transform.position = spawnPoint.position;
        currentHealth = maxHealth;
        
    }

    //Damage function
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    
    //Death function
    public void Die()
    {        
        print("You died");
        transform.position = GetComponent<Interact>().currentSpawn.transform.position;
        currentHealth = maxHealth;
    }
}
