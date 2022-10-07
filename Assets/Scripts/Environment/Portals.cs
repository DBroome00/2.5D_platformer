using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals : MonoBehaviour
{
    //Portal
    [SerializeField] private Transform destination;

    //Get portal destination
    public Transform GetDestination()
    {
        return destination;
    }
}
