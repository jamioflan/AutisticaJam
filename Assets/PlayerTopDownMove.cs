using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopDownMove : MonoBehaviour
{
    [Tooltip("Units per second")]
    public float MoveSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0f) * MoveSpeed * Time.deltaTime;
    }
}
