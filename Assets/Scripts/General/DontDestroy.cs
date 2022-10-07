using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    //Dont destroy this game object on load
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
