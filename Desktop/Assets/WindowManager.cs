using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public int windowIndex = 0;
    public bool isWindowOpen = false;

    // TaskBar
    public GameObject fileWindow;
    public GameObject viewWindow;
    public GameObject helpWindow;

    private void FixedUpdate()
    {
        // Taskbar
        if (isWindowOpen == false) {
            if (windowIndex == 1)
            {
                fileWindow.SetActive(true);
            }
            else
            {
                if (windowIndex == 2)
                {
                    viewWindow.SetActive(true);
                }
                else
                {
                    if (windowIndex == 3)
                    {
                        helpWindow.SetActive(true);
                    }
                }
            }
        }



    }
    public void closeTaskBar()
    {
        fileWindow.SetActive(false);
        viewWindow.SetActive(false);
        helpWindow.SetActive(false);
    }
}
