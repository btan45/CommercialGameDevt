using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIInput : MonoBehaviour
{
    public TMP_InputField inputField;

    private void Awake()
    {
        inputField = transform.Find("inputField").GetComponent<TMP_InputField>();
    }

    public void Show(string inputString)
    {
        inputField.text = inputString;
    }
}
