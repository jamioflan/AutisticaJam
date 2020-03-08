using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Rabbits : MonoBehaviour
{
    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 2);
    }
}
