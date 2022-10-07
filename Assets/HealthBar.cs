using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{

    private Image healthBar;

    public float health;

    private float maxHealth;

    Health Player;

    private void Start()
    {
        //find
        healthBar = GetComponent<Image>();
        Player = FindObjectOfType<Health>();
        maxHealth = FindObjectOfType<Health>().maxHealth;
    }

    private void Update()
    {
        health = Player.currentHealth;
        healthBar.fillAmount = health / maxHealth;
    }
}
