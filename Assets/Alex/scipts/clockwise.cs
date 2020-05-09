//author: Alexander Nelson
//Csci 448
//rotates that block clockwise
using UnityEngine;
using System.Collections;
using System;
public class clockwise : MonoBehaviour
{
	private Vector3 originalRot;
	private Vector3 targetRot;
	public void OnMouseDown()
	{
		float x = this.transform.rotation.eulerAngles.y;
		//Debug.Log(x);
		if (x != 90)
		{
			transform.Rotate(new Vector3(0f, 0f, 90f));
		}	
		if (x == 0)
		{
			++CompassBehaviour.count;
		}
	}

}

