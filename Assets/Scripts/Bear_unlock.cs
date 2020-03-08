using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear_unlock : MonoBehaviour
{
    public GameObject bearAnimated;
    public GameObject bearGone;
    public GameObject bearBarrier;

    private void Start()
    {
        bearAnimated.SetActive(false);
        bearBarrier.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Devin")
        {
            Destroy(bearGone);
            bearAnimated.SetActive(true);
            bearBarrier.SetActive(false);
        }
    }

}
