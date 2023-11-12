using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Transform parentAfterDrag;

    public TrashScript trashScript;

    public GameObject fileIcon;

    public bool isCoreDrivers = false;

    private void Start()
    {
        trashScript = GameObject.FindGameObjectWithTag("Trash").GetComponent<TrashScript>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();

        trashScript.fileToDestroy = gameObject;
        fileIcon.SetActive(true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End drag");
        transform.SetParent(parentAfterDrag);
        fileIcon.SetActive(false);
    }
}
