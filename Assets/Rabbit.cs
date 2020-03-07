using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{
	public float hopTimer, hopHeight = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
		hopTimer = Random.Range(0.0f, 100.0f);
    }

    // Update is called once per frame
    void Update()
    {
		hopTimer += Time.deltaTime;

		Vector3 pos = transform.localPosition;
		pos.z += Mathf.Sin(hopTimer * Mathf.PI) * hopHeight;
		transform.localPosition = pos;
	}
}
