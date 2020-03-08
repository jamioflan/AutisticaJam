using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoppingPanel : MonoBehaviour
{
	public Image hop1, hop2;
	public float hopTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		hopTimer += Time.deltaTime;
		bool frame2 = hopTimer % 2.0f > 1.0f;
		hop1.enabled = !frame2;
		hop2.enabled = frame2;
		Vector3 pos = hop1.rectTransform.localPosition;
		pos.y += Mathf.Sin(hopTimer * Mathf.PI) * 0.5f;
		hop1.rectTransform.localPosition = pos;

		pos = hop2.rectTransform.localPosition;
		pos.y += Mathf.Sin(hopTimer * Mathf.PI) * 0.5f;
		hop2.rectTransform.localPosition = pos;
	}
}
