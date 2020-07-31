using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class languageChosen : MonoBehaviour
{
    public Text palindromeLanguage;
    public Text pDALanguage_textField;
    string palLan = "XF3";
    string pDALan = "(XF3)";
    public void palindromeLanguag()
    {
        palindromeLanguage.text = palLan.ToString();
    }

    public void PDALanguag()
    {
        pDALanguage_textField.text = pDALan.ToString();
    }
}
