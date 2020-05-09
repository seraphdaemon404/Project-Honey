using UnityEngine;
using UnityEngine.SceneManagement;
public class backtomenu : MonoBehaviour
{
	private float bTime;
	void Start()
	{
		Time.timeScale = 1;

		bTime = Time.time;
	}


	// Update is called once per frame
	void Update()
    {

		//start ending sequence.
		if (Time.time - bTime >= 5.0f)
		{

			SceneManager.LoadScene("MainMenu");
		}
	}
}
