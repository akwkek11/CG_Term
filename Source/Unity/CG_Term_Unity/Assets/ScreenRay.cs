using UnityEngine;
using System.Collections;

public class ScreenRay : MonoBehaviour
{
    public int clickLayer = 8;
    public int blockLayer = 9;
    
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("hit !!");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo, 100f))
            {
                Debug.Log("hit point : " + hitInfo.point);

                int l = hitInfo.transform.gameObject.layer;

                if (l == clickLayer)
                {
                    Debug.Log(" hit object : " + hitInfo.collider.name);
                }
            }
        }
    }
}