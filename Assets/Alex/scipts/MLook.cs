using UnityEngine;
using System.Collections;
//Author Alexander Nelson
//CSci 448
[AddComponentMenu("Camera-Control/Mouse Look")]

public class MLook : MonoBehaviour
{
	public enum RotationAxes { mXAndY = 0, MX = 1, MY = 2 }
	public RotationAxes ax = RotationAxes.mXAndY;
	public float sensX = 10.0f;
	public float sensY = 10.0f;
	private float csensX;
	private float csensY;
	public float minX = -360.0f;
	public float maxX = 360.0f;
	public float minY = -60.0f;
	public float maxY = 60.0f;
	float rotationY = 0.0f;
	public CharacterMotor cmotor;

	void Update()
	{
		UpdateCSens();
		if (ax == RotationAxes.mXAndY)
		{
			float rotX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * csensX;
			rotationY += Input.GetAxis("Mouse Y") * csensY;

			transform.localEulerAngles = new Vector3(-rotationY, rotX, 0);
		}
		else if (ax == RotationAxes.MX)
		{
			transform.Rotate(0, Input.GetAxis("Mouse X") * csensX, 0);
		}
		else
		{
			rotationY += Input.GetAxis("Mouse Y") * csensY;
			rotationY = Mathf.Clamp(rotationY, minY, maxY);

			transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
		}
	}
	void UpdateCSens()
	{
		csensX = sensX;
		csensY = sensY;
	}
}