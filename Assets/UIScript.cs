using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text speedTxt;
    public Text lengthTxt;

    void Update()
    {
         
        speedTxt.text = "Current Speed : " + TrailManager.instance.trailSpeed.ToString();
        lengthTxt.text =  "Current Length : " + TrailManager.instance.length.ToString();
    }
    


}
