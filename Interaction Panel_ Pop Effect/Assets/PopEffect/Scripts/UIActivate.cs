using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIActivate : MonoBehaviour
{
    public void ActivateTake ()
    {
        Debug.Log("Item has been Obtained");
    }

    public void ActivateUse()
    {
        Debug.Log("Item is being use");
    }

    public void ActivateLook()
    {
        Debug.Log("Oh look! Its a useful Item!");
    }

    public void ActivateSpeak()
    {
        Debug.Log("Hello Item! Do you have feelings for me?");
    }
}
