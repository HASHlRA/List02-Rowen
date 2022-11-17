using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise04 : MonoBehaviour
{
    public TextMeshProUGUI attempts;
    private int currentattempts = 10;
    private int answerchosen;

    private int pcanswer;
    public GameObject[] randomGuess;

    private int successfulcount;
    public TextMeshProUGUI succesCoutnertext;

    private int mistakecount;
    public TextMeshProUGUI mistakeCounterText;

    private bool canClick = true;

    //Choices between the buttons
    public void OptionButton(int number)
    {
        if (currentattempts > 0 && canClick)
        {
            randomGuess[pcanswer].SetActive(false);
            answerchosen = number;
            currentattempts--;
            attempts.text = currentattempts.ToString();
            StartCoroutine(RandomOption());
        }
    }

    //Randomized the PC's answer and displays it on the screen
    private IEnumerator RandomOption()
    {
        canClick = false;
        pcanswer = Random.Range(0, 2);
        randomGuess[pcanswer].SetActive(true);

        //+1 if we choose the same as the PC(success)
        if (pcanswer == answerchosen)
        {
            successfulcount++;
        }
        //+1 if we choose the same as the pc (mistake)
        else
        {
            mistakecount++;
        }

        //If the attempts reaches 0, the results will be desplayed on the screen
        if (currentattempts == 0)
        {
            yield return new WaitForSeconds(1f);
            randomGuess[pcanswer].SetActive(false);
            succesCoutnertext.gameObject.SetActive(true);
            mistakeCounterText.gameObject.SetActive(true);
            succesCoutnertext.text = $"{successfulcount} guessed right";
            mistakeCounterText.text = $"{mistakecount} guessed wrong";
        }

        canClick = true;
    }
}
