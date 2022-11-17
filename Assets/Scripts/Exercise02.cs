using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Exercise02 : MonoBehaviour
{
    public float timer = 10;
    public float maxTime; 
    public TextMeshProUGUI timerNumber;

    public Image timeBar;

    private bool counter = false;
    private bool click = true;


    void Start()
    {
        // Shows the predetermined number
        timerNumber.text = timer.ToString(); 
    }

    void Update()
    {
        // Reduces the timer account adn the bar amount if it is more than zero
        if (counter && timer > 0)
        {
            timer -= Time.deltaTime;
            timerNumber.text = Mathf.Round(timer).ToString();
            timeBar.fillAmount = timer / maxTime;
        }

        // If it reaches zero
        if (timer <= 0 && counter) 
        {
            click = true; 
            counter = false; 
            timer = maxTime; 
            timerNumber.text = timer.ToString();
        }
    }

    // Adds 1 second
    public void MoreTime()
    {
        if (counter == false)
        {
            timer += 1;
            timerNumber.text = timer.ToString();
        }

    }

    // Reduces 1 second
    public void LessTime()
    {
        if (counter == false)
        {
            timer -= 1;
            timerNumber.text = timer.ToString();
        }
    }

    // Starts the timer
    public void StartButton()
    {
        if (click == true)
        {
            counter = true;
            maxTime = timer;
            click = false;
        }
    }
}
