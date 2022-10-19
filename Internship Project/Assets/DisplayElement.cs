using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayElement : MonoBehaviour
{
    public string[] elements;
    public TextMeshProUGUI text;
    public string chosenelement;
    // Start is called before the first frame update
    void Start()
    {
        ShowElement();
    }

    public void ShowElement()
    {
        int elementnum = Random.Range(0, 118);
        text.text = "Element Number: " + elementnum.ToString();
        chosenelement = elements[elementnum - 1];
    }
}
