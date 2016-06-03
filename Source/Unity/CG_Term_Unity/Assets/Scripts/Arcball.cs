using UnityEngine;
using System.Collections;

public class Arcball : MonoBehaviour
{
    public float radius = 500.0f;
    public GameObject target;
    private float mouseX = 0.0f,
                  mouseZ = 0.0f;
    private Vector3 up = new Vector3(0.0f, 1.0f, 0.0f),
            right = new Vector3(0.0f, 0.0f, 1.0f),
            newPosition = Vector3.zero;

    private Camera came;
	// Use this for initialization
	void Start ()
    {
        came = GetComponent<Camera>();
        came.transform.position = new Vector3(radius, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        newPosition = transform.position;
        //if(Input.GetMouseButton(0))
        //if (Input.GetTouch(0).phase == TouchPhase.Moved)
        //{
        Touch touch = Input.GetTouch(0);
       // mouseX = Input.GetAxis("Mouse X");
        //mouseZ = Input.GetAxis("Mouse Y");
        mouseX = touch.deltaPosition.x;
        mouseZ = touch.deltaPosition.y;
            //mouseX = Input.GetAxis("Horizontal");
            //mouseZ = Input.GetAxis("Vertical");
        //}
        /*else
        {
            mouseX = Mathf.Lerp(mouseX, 0.0f, 0.2f);
            mouseZ = Mathf.Lerp(mouseZ, 0.0f, 0.2f);
        }*/
        newPosition += right * mouseX * radius / 40.0f
                        + up * mouseZ * -radius / 40.0f;
        newPosition.Normalize();
        right = Vector3.Cross(up, newPosition);
        up = Vector3.Cross(newPosition, right);

        right.Normalize();
        up.Normalize();
        newPosition.Normalize();
        came.transform.position = newPosition * radius;

        came.transform.LookAt(target.transform.position, up);
    }
}
