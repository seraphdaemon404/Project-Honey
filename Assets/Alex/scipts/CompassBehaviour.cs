using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
public class CompassBehaviour : MonoBehaviour
{
	public static int count=0;
	public bool compass = true;
	private Texture endstill;
	private float bTime;
void Start()
	{
		Time.timeScale = 1;
		 
		bTime = Time.time;
	}
	void Update()
	{
		//Debug.Log(count);
		if(count==4 && compass==true)
		{
			SceneManager.LoadScene("end");
		}
	}
}
