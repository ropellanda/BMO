using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWindowScript : MonoBehaviour
{
    public void OpenWindow(GameObject window)
    {
        window.SetActive(true);
    }


    public void AutoCloseWindow(GameObject windowToClose)
    {
       windowToClose.SetActive(false);
    }
}
