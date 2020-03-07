using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    [Tooltip("The object (player) that this camera will follow")]
    public Transform Target;
    [Header("Pan settings")]
    [Tooltip("How fast to recenter the camera")]
    [Range(1f, 2.5f)]
    public float DistanceDecay = 2f;
    [Tooltip("The maximum speed (units per second) at which the camera can pan. ")]
    [Range(1f, 8f)]
    public float MaxPanSpeed = 6f;
    [Tooltip("The farthest distance from the target before clamping")]
    [Range(2f, 10f)]
    public float MaxTargetDistance = 4f;
    [Tooltip("Targeting deadzone, will not move the camera while the target distance is below this amount")]
    [Range(0f, 5f)]
    public float MinTargetDistance = 0f;
    [Tooltip("General difference multiplier")]
    [Range(-1f, 1f)]
    public float OffsetMultiplier = 1f;

    [Space]
    [Header("Debug")]
    public float ZOffset = -10f;
    //public Vector3 MovementAxis = new Vector3(1f, 1f, 0f);
    public Vector3 lastPosition;
    public Vector3 panPosition;

    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
        panPosition = lastPosition;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 position;
        if (Target == null)
            position = lastPosition;
        else
            position = Target.position;

        Vector3 difference = Vector3SetZ(position - panPosition, 0f);
        float dmag = difference.magnitude;
        if (dmag > MaxTargetDistance)
        {
            panPosition += difference.normalized * (dmag - MaxTargetDistance);
        }

        difference = difference.normalized * Mathf.Clamp((dmag - MinTargetDistance) * (DistanceDecay * DistanceDecay * Time.deltaTime), 0f, MaxPanSpeed * Time.deltaTime);
        panPosition += difference;

        transform.position = Vector3SetZ(position + (panPosition - position) * OffsetMultiplier, ZOffset);

        lastPosition = position;
    }

    static Vector3 Vector3SetZ(Vector3 A, float Z) => new Vector3(A.x, Z, A.y);

    static Vector3 Vector3Multiply(Vector3 A, Vector3 B) =>
        new Vector3(A.x * B.x, A.y * B.y, A.z * B.z);
}
