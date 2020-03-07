using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVol : MonoBehaviour
{
	private SphereCollider trigger;
	public Character character;

	// Start is called before the first frame update
	void Start()
    {
		trigger = GetComponent<SphereCollider>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider collision)
	{
		Debug.Log("Collision enter " + collision.name);
		if (collision.GetComponent<PlayerTopDownMove>())
		{
			collision.GetComponent<PlayerTopDownMove>().canInteractWith = character;
		}
	}

	private void OnTriggerExit(Collider collision)
	{
		Debug.Log("Collision exit " + collision.name);
		if (collision.GetComponent<PlayerTopDownMove>())
		{
			if (collision.GetComponent<PlayerTopDownMove>().canInteractWith == character)
				collision.GetComponent<PlayerTopDownMove>().canInteractWith = null;
		}
	}
}
