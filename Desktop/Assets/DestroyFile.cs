using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFile : MonoBehaviour
{
    public TrashScript trashScript;

    private void Start()
    {
        trashScript = GameObject.FindGameObjectWithTag("Trash").GetComponent<TrashScript>();    
    }

    public void DragToTrash()
    {
        trashScript.fileToDestroy = gameObject;
    }
}
