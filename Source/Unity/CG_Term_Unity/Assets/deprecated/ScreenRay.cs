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

            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                Debug.Log("hit point : " + hitInfo.point);

                if (hitInfo.transform.tag.Equals("ImposObj"))
                {
                    Debug.Log(" hit object : " + hitInfo.collider.name);
                }
            }
        }
    }
}