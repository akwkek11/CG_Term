using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{

    public Transform target;
    public float dist = 10.0f;
    public float height = 5.0f;
    public float dampRotate = 5.0f;   
    public float TurnSpeed;
    public float camPos;

    Vector3 V3;

    private Transform tr;
    void Start()
    {
        tr = GetComponent<Transform>();
        TurnSpeed = 2f;
        camPos = 2f;
    }

    void Update()
    {
        Vector3 PositionInfo = tr.position - target.position;
        PositionInfo = Vector3.Normalize(PositionInfo); 

        target.transform.Rotate(0, Input.GetAxis("Horizontal") * TurnSpeed, 0); 
        transform.RotateAround(target.position, Vector3.right, Input.GetAxis("Mouse X") * TurnSpeed);
        transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse Y") * TurnSpeed);
    }
}