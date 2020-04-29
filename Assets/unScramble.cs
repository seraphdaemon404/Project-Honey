using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class unScramble : MonoBehaviour
{
    public string guess;
    public GameObject inputField;
    public GameObject textDisplay;
    AudioSource congrats;

    private void Start()
    {
        congrats = GetComponent<AudioSource>();
    }
    public void storeGuess()
    {
        guess = inputField.GetComponent<Text>().text;
        if (guess == "cavern"|| guess =="Cavern" || guess == "CAVERN")
        {
            congrats.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            BridgeBehavior.fall = true;

        }
        else
        {
            textDisplay.GetComponent<Text>().text = "Incorrect";

        }
    }
}
