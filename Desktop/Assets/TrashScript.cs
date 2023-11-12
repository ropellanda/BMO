using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class TrashScript : MonoBehaviour
{
    public GameObject fileToDestroy;

    public GameObject fileIcon;

    public Sprite openTrash;
    public Sprite closedTrash;

    public Image trashImage;

    public DraggableScript coreDriversCheck;

    public bool hasDestroyedDrivers = false;

    public GameObject crack;

    public GameObject bmoError;
    public VideoPlayer driversFailure;

    public void Start()
    { 
        trashImage = GameObject.FindGameObjectWithTag("Trash").GetComponent<Image>();
        if (PlayerPrefs.GetInt("fixed") == 1)
        {
            crack.SetActive(true);
        } else
        {
            crack.SetActive(false);
        }
    }

    public void DeleteFile()
    {
        Destroy(fileToDestroy);
        fileIcon.SetActive(false);
        if (fileToDestroy == GameObject.FindGameObjectWithTag("CoreDrivers"))
        {
            crack.SetActive(true);
            PlayerPrefs.SetInt("fixed", 1);
            PlayerPrefs.Save();
            StartCoroutine(DriverError());
        }
    }

    public void OpenTrashCan()
    {
        trashImage.sprite = openTrash;
    }

    public void CloseTrashCan()
    {
        trashImage.sprite = closedTrash;
    }

    public IEnumerator DriverError()
    {
        bmoError.SetActive(true);
        driversFailure.Play();
        Cursor.visible = false;
        yield return new WaitForSeconds(9);
        bmoError.SetActive(false);
        Cursor.visible = true;
    }
}
