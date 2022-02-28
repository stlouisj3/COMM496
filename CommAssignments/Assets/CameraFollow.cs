using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] [Range(0.01f ,1f)]
    private float smoothSpeed = 0.125f;
    [SerializeField] private Vector3 offset = new Vector3(0f,2.25f,-2.5f);
    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
    }
    private void CenterOnTarget()
    {
        transform.position = target.position + offset;
    }
}
