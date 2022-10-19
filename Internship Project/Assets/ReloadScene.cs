using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReloadScene : MonoBehaviour
{
    public DisplayElement DE;
    public TMP_InputField InputField; 
    public void Reload()
    {
        DE.ShowElement();
        InputField.text = "";
    }

    public void DisableSelf()
    {
        gameObject.SetActive(false);
    }
}
