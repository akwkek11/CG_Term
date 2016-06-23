using UnityEngine;
using System.Collections;

public class MyGUI : MonoBehaviour 
{
	public CameraMover MyCameraMover;

	void OnGUI()
	{
		if (GUILayout.Button("Penrose triangle"))
		{
			this.MyCameraMover.StartCoroutine(this.MyCameraMover.MoveToPosition(1, 1f));
		}
		if (GUILayout.Button("Impossible Cube"))
		{
			this.MyCameraMover.StartCoroutine(this.MyCameraMover.MoveToPosition(2, 1f));
		}
        if (GUILayout.Button("Impossible Cube 2"))
        {
            this.MyCameraMover.StartCoroutine(this.MyCameraMover.MoveToPosition(3, 1f));
        }
        if (GUILayout.Button("Penrose Stair"))
        {
            this.MyCameraMover.StartCoroutine(this.MyCameraMover.MoveToPosition(4, 1f));
        }
    }
}
