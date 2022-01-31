using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class roomSizeCalculation : MonoBehaviour
{
   public void calculateSize()
    {

        if (StaticVariable.size == "large")
        {
            StaticVariable.length =6.71f;
            StaticVariable.width =8.53f;
        }
        else if (StaticVariable.size == "medium")
        {
            StaticVariable.length =4.88f;
            StaticVariable.width =6.01f;
        }
        else if (StaticVariable.size == "small")
        {
            StaticVariable.length =3.66f;
            StaticVariable.width =5.49f;
        }
        else if (StaticVariable.size == "exsmall")
        {
            StaticVariable.length =3.05f;
            StaticVariable.width =3.66f;
        }
    }
}
