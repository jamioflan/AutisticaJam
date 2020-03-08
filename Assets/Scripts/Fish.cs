using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public GameObject fishUI;
    public GameObject DevinFish;

    private void Start()
    {
        fishUI.SetActive(false);
        DevinFish.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Devin")
        {
            fishUI.SetActive(true);
            DevinFish.SetActive(true);
        }
    }
}
