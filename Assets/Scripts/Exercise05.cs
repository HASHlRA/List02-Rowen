using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise05 : MonoBehaviour
{
    public string[] zodiacs;
    public GameObject inputPanel;
    public TMP_InputField yearInputField;

    public GameObject zodiacPanel;
    public TextMeshProUGUI yourZodiac;
    public Image zodiacimg;
    public Sprite[] zodiac;


    public int year;
    public int zodiacInt;

    void Start()
    {
        returnButton();
    }

    //We confirm the year put on the input field
    public void ConfirmButton()
    {
        if (yearInputField.text != "")
        {
            year = int.Parse(yearInputField.text); 
            zodiacInt = year % 12;

            zodiacPanel.SetActive(true);
            inputPanel.SetActive(false);

            yourZodiac.text = $"Your chinese zodiac is the {zodiacs[zodiacInt]}";
            zodiacimg.sprite = zodiac[zodiacInt];
        }

    }

    //We go to the other panel that shows your zodiac year and the return button
    public void returnButton()
    {
        inputPanel.SetActive(true);
        zodiacPanel.SetActive(false);
    }
}
