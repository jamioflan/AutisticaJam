﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopDownMove : MonoBehaviour
{

    [Tooltip("Units per second")]
    public float MoveSpeed = 2f;

	private CharacterController cc;



	public SpriteSet sprites;

	public float blinker = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
		cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 input = new Vector3( Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

		ClearSprites();
		if( Mathf.Abs(input.x) > Mathf.Abs(input.z)) // Moving left-right
		{
			if (input.x > 0)
				sprites.right.enabled = true;
			else if (input.x < 0)
				sprites.left.enabled = true;
		}
		else
		{
			if (input.z > 0)
				sprites.back.enabled = true;
			else
				sprites.forward.enabled = true;
		}

		if(sprites.forward.enabled)
		{
			blinker += Time.deltaTime;
			if (blinker % 3.0f < 0.2f)
				sprites.blink.enabled = true;
		}

		cc.Move(input * MoveSpeed * Time.deltaTime);

		if(Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log("Pressed space");
			if (canInteractWith != null)
			{

				Debug.Log("Interacted with "+ canInteractWith.name);
				canInteractWith.Interact();
				SpriteSet newsprites = canInteractWith.sprites;

				canInteractWith.sprites = sprites;
				canInteractWith.sprites.transform.SetParent(canInteractWith.transform);
				canInteractWith.sprites.transform.localPosition = Vector3.zero;

				sprites = newsprites;
				sprites.transform.SetParent(transform);
				sprites.transform.localPosition = Vector3.zero;
			}
		}
    }

	void ClearSprites()
	{
		sprites.forward.enabled = false;
		sprites.back.enabled = false;
		sprites.left.enabled = false;
		sprites.right.enabled = false;
		sprites.blink.enabled = false;
	}

	public Character canInteractWith = null;


}
