using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//https://www.youtube.com/watch?v=TWxXD-UpvSg
public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    void Start()
    {

    }
    void Update()
    {
        if(isInRange)
        {
            if(Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isInRange = true;
            Debug.Log("In Range");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isInRange = false;
            Debug.Log("Out of Range");
        }
    }

}


