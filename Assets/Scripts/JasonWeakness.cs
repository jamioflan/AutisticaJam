using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemmaWeakness : MonoBehaviour
{

    public GameObject bubble;

    private void Start()
    {
        bubble.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Gemma")
        {
            bubble.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        bubble.SetActive(false);
    }

}
