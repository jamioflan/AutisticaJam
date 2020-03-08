using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeGrass : MonoBehaviour
{
    public GameObject red;

    private void Start()
    {
        red.SetActive(true);
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Jason")
        {
            red.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        red.SetActive(true);
    }


}
