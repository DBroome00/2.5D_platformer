using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    //get player
    [SerializeField] private Transform player;

    //get player position and follow the player when the player moves.
    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, player.position.z -20);
    }
}
