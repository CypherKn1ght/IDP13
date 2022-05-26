using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemicalReactor : MonoBehaviour
{
    public bool chem1;
    public bool chem2;
    public InventoryObject inventory;
    public void setChemTrue(DefaultObject chemOne, DefaultObject chemTwo)
    {
        if (inventory.Container[inventory.selectedSlot].item == chemOne)
        {
            chem1 = true;
        }
        else if (inventory.Container[inventory.selectedSlot].item == chemTwo)
        {
            chem2 = true;
        }
        
    }
    public bool itemCreate(bool chem1, bool chem2)
    {
        if (chem1 && chem2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void Update()
    {
        itemCreate(chem1, chem2);
    }
}
