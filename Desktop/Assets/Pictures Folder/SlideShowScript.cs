using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideShowScript : MonoBehaviour
{
    public Image slideShow;

    public Sprite[] images;

    public int index = 0;

    private void Update()
    {
        if (index == 0)
        {
            IncreaseIndex(0);
            slideShow.transform.localScale = new Vector2(0.5f, 0.5f);
        } else
        {
            if (index == 1)
            {
                IncreaseIndex(1);
                slideShow.transform.localScale = new Vector2(0.6f, 0.6f);
            } else
            {
                if (index == 2)
                {
                    IncreaseIndex(2);
                    slideShow.transform.localScale = new Vector2(0.5f, 0.5f);
                } else
                {
                    if (index == 3)
                    {
                        IncreaseIndex(3);
                        slideShow.transform.localScale = new Vector2(0.5f, 0.5f);
                    } else
                    {
                        if (index == 4)
                        {
                            IncreaseIndex(4);
                            slideShow.transform.localScale = new Vector2(0.6f, 0.6f);
                        } else
                        {
                            if (index == 5)
                            {
                                IncreaseIndex(5);
                                slideShow.transform.localScale = new Vector2(1, 1);
                            } else
                            {
                                if (index == 6)
                                {
                                    IncreaseIndex(6);
                                    slideShow.transform.localScale = new Vector2(0.7f, 0.7f);
                                } else
                                {
                                    if (index == 7)
                                    {
                                        IncreaseIndex(7);
                                        slideShow.transform.localScale = new Vector2(0.8f, 0.8f);
                                    } else
                                    {
                                        if (index == 8)
                                        {
                                            IncreaseIndex(8);
                                            slideShow.transform.localScale = new Vector2(0.7f, 0.7f);
                                        } else
                                        {
                                            if(index == 9)
                                            {
                                                IncreaseIndex(9);
                                                slideShow.transform.localScale = new Vector2(0.7f, 0.7f);
                                            } else
                                            {
                                                if (index == 10)
                                                {
                                                    IncreaseIndex(10);
                                                    slideShow.transform.localScale = new Vector2(0.7f, 0.7f);
                                                } else
                                                {
                                                    if (index == 11)
                                                    {
                                                        IncreaseIndex(11);
                                                        slideShow.transform.localScale = new Vector2(0.7f, 0.7f);
                                                    } else
                                                    {
                                                        if (index == 12)
                                                        {
                                                            IncreaseIndex(12);
                                                            slideShow.transform.localScale = new Vector2(0.45f, 0.45f);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }


    public void IncreaseIndex(int newIndex)
    {
        slideShow.sprite = images[newIndex];
        slideShow.SetNativeSize();
    }
}
