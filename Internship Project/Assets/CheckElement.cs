using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckElement : MonoBehaviour
{
    public DisplayElement DE;
    public GameObject DisplayCorrect;
    public GameObject DisplayIncorrect;
    public int correctamount;
    int incorrectamount;
    public TextMeshProUGUI correcttext;
    public TextMeshProUGUI incorrecttext;
    public Transform CorrectBar;
    public Transform IncorrectBar;

    public GameOver gameover;
    public void Check(string str)
    {
        if(str.ToLower() == DE.chosenelement.ToLower())
        {
            Debug.Log("Correct");
            correctamount += 1;
            DisplayCorrect.SetActive(true);
            gameover.correct = correctamount;
        }
        else
        {
            incorrectamount += 1;
            Debug.Log("Incorrect");
            DisplayIncorrect.SetActive(true);
            gameover.incorrect = incorrectamount;
        }
        ApplyScore();
        ApplyBars();
    }

    void ApplyScore()
    {
        correcttext.text = correctamount.ToString();
        incorrecttext.text = incorrectamount.ToString();
    }

    void ApplyBars()
    {
        int total = correctamount + incorrectamount;
        if(correctamount != incorrectamount)
        {
            CorrectBar.localScale = new Vector2(20f / total * correctamount, 1.2f);
            IncorrectBar.localScale = new Vector2(20f / total * incorrectamount, 1.2f);
        }
        else
        {
            CorrectBar.localScale = new Vector2(10, 1.2f);
            IncorrectBar.localScale = new Vector2(10, 1.2f);
        }

    }


}
