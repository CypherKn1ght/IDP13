using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[SerializeField]
public class Inventory_Handler : MonoBehaviour
{
    public TextMeshProUGUI fail;
    public InventoryObject inventory;
    [SerializeField]
    public void AddItem(bool canRun, DefaultObject item)
    {
        if (canRun)
        {
            inventory.AddItem(item, 1);
        }
        
    }
    public void RemoveItem(bool canRun, DefaultObject item)
    {
        if (canRun)
        {
            inventory.RemoveItem(item, 1);
        }
        
    }
    public bool ItemInteract(DefaultObject item)
    {
        if (inventory.CheckItem(item))
        {
            Debug.Log("You have the item");
        }
        else
        {
            Debug.Log("You don't have the item");
        }
        return inventory.CheckItem(item);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            inventory.selectedSlot = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            inventory.selectedSlot = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            inventory.selectedSlot = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            inventory.selectedSlot = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            inventory.selectedSlot = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            inventory.selectedSlot = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            inventory.selectedSlot = 6;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            inventory.selectedSlot = 7;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            inventory.selectedSlot = 8;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            inventory.selectedSlot = 9;
        }
    }

}

