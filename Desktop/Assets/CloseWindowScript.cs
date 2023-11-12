using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWindowScript : MonoBehaviour
{
    public void CloseWindow(GameObject window)
    {
        window.SetActive(false);
    }
}
