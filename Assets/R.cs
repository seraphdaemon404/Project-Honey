using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class R : MonoBehaviour
{
    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;
    AudioSource congrats;

    // Start is called before the first frame update
    void Start()
    {
        congrats = GetComponent<AudioSource>();
        //playNoise();
        myText = GameObject.Find("RText").GetComponent<Text>();
        //myText.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        FadeText();
    }

    void OnMouseDown()
    {
        ++BridgeBehavior.count;
        displayInfo = true;
        playNoise();
    }

    //void OnMouseExit()
    //{
    //   displayInfo = false;
    //}

    void playNoise()
    {
        congrats.Play();
    }

    void FadeText()
    {
        if (displayInfo)
        {
            //playNoise();
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, Color.black, fadeTime * Time.deltaTime);
            //gameObject.active = false;
        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}
