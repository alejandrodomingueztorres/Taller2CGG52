using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string stringName;

    public void ReadNameString(string name)
    {
        if (name.Length == 0)
        {
            Debug.Log("Nombre no valido");
        }
        else
        {
            stringName = name;
            Debug.Log(stringName);



        }
            

    }
}
