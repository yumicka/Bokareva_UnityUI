using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScrip : MonoBehaviour
{
    string vards;
    int gads;
    int vecums;
    public GameObject inputField;
    public GameObject inputField2;
    public GameObject displayField;

    public void getText(){
        vards = inputField.GetComponent<InputField>().text;

        if (int.TryParse(inputField2.GetComponent<InputField>().text, out gads)) {
            vecums = 2024 - gads;
            displayField.GetComponent<Text>().text = vards + " ir " + vecums + " gadi!";
        }

}
}
