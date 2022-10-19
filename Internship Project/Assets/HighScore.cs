using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Score") != null)
        {
            GetComponent<TextMeshProUGUI>().text = "HighScore: "+ PlayerPrefs.GetInt("Score").ToString();
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = "HighScore: 0";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
