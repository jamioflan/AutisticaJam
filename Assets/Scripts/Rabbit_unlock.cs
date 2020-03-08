using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit_unlock : MonoBehaviour
{
    public GameObject rabbitAnimated;
    public GameObject rabbitGone;
    public GameObject rabbitBarrier;

    private void Start()
    {
        rabbitAnimated.SetActive (false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gemma")
        {
            Destroy(rabbitGone);
            rabbitAnimated.SetActive(true);
            rabbitBarrier.SetActive(false);
        }
    }

}
