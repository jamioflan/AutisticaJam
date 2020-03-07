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
		PlayerTopDownMove player = collision.GetComponent<PlayerTopDownMove>();
		if (player)
		{
			player.canInteractWith = character;
			player.pressSpaceObject.SetActive(true);
			player.pressSpaceText.text = "Press Space to Help " + character.name;
		}
	}

	private void OnTriggerExit(Collider collision)
	{
		Debug.Log("Collision exit " + collision.name);
		PlayerTopDownMove player = collision.GetComponent<PlayerTopDownMove>();
		if (player)
		{
			if (player.canInteractWith == character)
			{
				player.canInteractWith = null;

				player.pressSpaceObject.SetActive(false);
			}
		}
	}
}
