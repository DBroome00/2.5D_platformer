using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{


    //Patrol Point variables
    [Header("Patrol Points")]
    [SerializeField] private Transform leftEdge;
    [SerializeField] private Transform rightEdge;

    //Get enemy
    [Header("Enemy Position")]
    [SerializeField] private Transform enemy;


    //enemy movement variables
    [Header("Movement")]
    [SerializeField] private float enemySpeed;
    private bool moveingLeft;

    // how long should the enemy wait at each patrol point
    [Header("Idle")]
    [SerializeField] private float idleDuration;
    private float idleTimer;

    //check if the enemy has reached a patrol point and then calls for the idle function and then a change of direction
    private void Update()
    {
        if (moveingLeft)
        {
            if (enemy.position.x >= leftEdge.position.x)
                MoveInDirection(-1);
            else
            {
                DirectionChange();
            }
        }
        else
        {
            if (enemy.position.x <= rightEdge.position.x)
                MoveInDirection(1);
            else
            {
                DirectionChange();
            }
        }
    }

    // Change direction
    private void DirectionChange()
    {
        idleTimer += Time.deltaTime;

        if (idleTimer > idleDuration)

            moveingLeft = !moveingLeft;
    }


    // Start moving in new direction if idleTimer is 0
    private void MoveInDirection(int _direction)
    {
        idleTimer = 0;

        enemy.position = new Vector3(enemy.position.x + Time.deltaTime * _direction * enemySpeed,
                                        enemy.position.y, enemy.position.z);
    }
}