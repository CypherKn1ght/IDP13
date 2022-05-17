/*  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interact : MonoBehaviour
{
    public GameObject interactIcon;
    // Start is called before the first frame update
    void Start()
    {
        interactIcon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            CheckInteract();
        }
    }
    public void OpenIcon()
    {
        interactIcon.SetActive(true);
    }
    public void CloseIcon()
    {
        interactIcon.SetActive(false);
    }
    private void CheckInteract()
    {
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position);
    }
}
*/