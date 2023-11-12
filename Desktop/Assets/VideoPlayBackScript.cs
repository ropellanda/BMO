using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayBackScript : MonoBehaviour
{
    public videoScript videoScript;

    public void NextVideo()
    {
        if (videoScript.videoIndex == 0)
        {
            videoScript.videoIndex += 1;
        } else
        {
            videoScript.videoIndex = 0;
        }
    }

    public void PreviousVideo()
    {
        if (videoScript.videoIndex == 1)
        {
            videoScript.videoIndex --;
        }
        else
        {
            videoScript.videoIndex = 1;
        }
    }
}
