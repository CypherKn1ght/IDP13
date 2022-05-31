using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

//https://www.youtube.com/watch?v=TWxXD-UpvSg
public class Interactable : MonoBehaviour
{
    public GameObject image;
    public bool isInRange;
    public KeyCode interactKey;
    public UltEvents.UltEvent enterAction;
    public UltEvents.UltEvent exitAction;
    public UltEvents.UltEvent interactAction;
    void Start()
    {

    }
    void Update()
    {
        if(isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = true;
            enterAction.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = false;
            exitAction.Invoke();
        }
    }
    public void showInteract(bool canRun,string textToDisplay)
    {
        if (canRun)
        {
            image.SetActive(true);
            image.GetComponentInChildren<TextMeshProUGUI>().text = textToDisplay;
        }
        else
        {
            image.SetActive(false);
        }
    }
    
    
}

