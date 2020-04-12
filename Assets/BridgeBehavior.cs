using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeBehavior : MonoBehaviour
{
    AudioSource BridgeFalling;

    void Start()
    {
        BridgeFalling = GetComponent<AudioSource>();
    }
    IEnumerator RotateMe(Vector3 byAngles, float inTime)
    {
        var fromAngle = transform.rotation;
        var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
        for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
        {
            transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            
            StartCoroutine(RotateMe(Vector3.forward * 90, 0.8f));
            BridgeFalling.Play();
        }
        if (Input.GetKeyDown("q"))
        {
            StartCoroutine(RotateMe(Vector3.forward * -90, 0.8f));
        }
    }
}
