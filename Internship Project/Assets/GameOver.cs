using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public int incorrect;
    public int correct;

    void Update()
    {
        if(incorrect >= 3)
        {
            loadswitch();
        }
    }

    public void loadswitch()
    {
        PlayerPrefs.SetInt("Score", correct);
        SceneManager.LoadScene("MainMenu");
    }


}
