using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSet : MonoBehaviour
{
	public SpriteRenderer forward, back, left, right, blink;

	public GameObject infoPanelUI;

	public void Start()
	{
		infoPanelUI.SetActive(false);
	}
}
