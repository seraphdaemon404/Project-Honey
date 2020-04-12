using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//Author: Alexander Nelson
//Class:  CSci 448
[RequireComponent(typeof(CharacterMotor))]
[AddComponentMenu("Character/FPS Input Controller")]

public class FPSInput : MonoBehaviour
{
	private CharacterMotor m;

	void Awake()
	{
		m = GetComponent<CharacterMotor>();
	}

	void Update()
	{
		Vector3 dVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		if (dVector != Vector3.zero)
		{
			float dLength = dVector.magnitude;
			dVector = dVector / dLength;

			dLength = Mathf.Min(1.0f, dLength);
			dLength = dLength * dLength;
			dVector = dVector * dLength;
		}
		m.inputMoveDirection = transform.rotation * dVector;
		m.inputJump = Input.GetButton("Jump");
	}
}
