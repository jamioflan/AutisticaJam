using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSet : MonoBehaviour
{
	public SpriteRenderer forward, back, left, right, blink, hop;

	public GameObject infoPanelUI;

	public bool gameComplete = false;

	public void Start()
	{
		infoPanelUI.SetActive(false);
	}
}
