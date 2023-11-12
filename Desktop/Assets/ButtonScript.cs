using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public SlideShowScript slideShow;

    private void Start()
    {
        slideShow = GameObject.FindGameObjectWithTag("Slideshow").GetComponent<SlideShowScript>();    
    }

    public void NextImage()
    {
        if (slideShow.index == 12)
        {
            slideShow.index = 0;
        } else
        {
            slideShow.index += 1;
        }
    }

    public void previousImage()
    {
        if (slideShow.index == 0) {
            slideShow.index = 12;
        } else
        {
            slideShow.index --;
        }
    }
}
