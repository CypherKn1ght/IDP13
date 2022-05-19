using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Handler : MonoBehaviour
{
    public InventoryObject inventory;
    public void AddItem(Item item)
    {
        Debug.Log("Item Given");
        inventory.AddItem(item, 1);
        //Destroy(item);

    }
}


