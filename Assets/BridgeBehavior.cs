using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BridgeBehavior : MonoBehaviour
{
    AudioSource BridgeFalling;
    public static int count;
    public bool stop =true;
    public static bool fall = false;
    public GameObject bridgeStop;
    void Start()
    {
        BridgeFalling = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (count == 4 && stop==true){
            count = 0;
            StartCoroutine(ExecuteAfterTime(2));
        }
        if (fall == true)
        {
            transform.Rotate(0, 0, 90);
            Destroy(bridgeStop);
            fall = false;
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
