using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class videoScript : MonoBehaviour
{
    public VideoPlayer silksong;
    public VideoPlayer bemore;

    public RawImage imageOutput;

    public int videoIndex = 0;

    void Update()
    {
        if (videoIndex == 0)
        {
            bemore.Stop();
            imageOutput.texture = silksong.texture;
            silksong.Play();
        } else
        {
            if (videoIndex == 1)
            {
                silksong.Stop();
                imageOutput.texture = bemore.texture;
                bemore.Play();
            }
        }
    }
}
