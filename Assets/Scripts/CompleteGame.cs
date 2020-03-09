using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteGame : MonoBehaviour
{ 
    public GameObject whiteFade;

    private void Start()
    {
        whiteFade.SetActive (false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Devin")
        {
            whiteFade.SetActive (true);

            SceneManager.LoadScene("ThanksForPlaying");
        }
    }
}

