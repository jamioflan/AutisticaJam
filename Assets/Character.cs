using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PlayerTopDownMove;

public class Character : MonoBehaviour
{
	public SpriteSet sprites;

	public float blinker = 0.0f;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		sprites.back.enabled = false;
		sprites.forward.enabled = true;
		sprites.left.enabled = false;
		sprites.right.enabled = false;
		sprites.blink.enabled = false;

		blinker += Time.deltaTime;
		if (blinker % 3.0f < 0.2f)
			sprites.blink.enabled = true;
	}

	public void Interact()
	{

	}
}
