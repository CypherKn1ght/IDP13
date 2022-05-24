using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>();
    public int selectedSlot = 0;
    public void AddItem(ItemObject _item, int _amount)
    {

        bool hasItem = false;
        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item == _item)
            {
                Container[i].AddAmount(_amount);
                hasItem = true;
                break;
            }
        }
        if (!hasItem)
        {
            SetEmptySlot(_item, _amount);
        }
    }
    public void RemoveItem(ItemObject _item, int _amount)
    {
        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item == _item)
            {
                Container[i].RemoveAmount(_amount);
                if (Container[i].amount <= 0)
                {
                    Container.RemoveAt(i);
                }
                break;
            }
        }
    }
    public bool CheckItem(ItemObject _item)
    {
        if (Container[selectedSlot].item == _item)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public InventorySlot SetEmptySlot(ItemObject _item, int _amount)
    {
        for (int i = 0; i < Container.Count; i++)
        {
            if(Container[i].item == null)
            {
                Container[i].UpdateSlot(_item, _amount);
                return Container[i];
            }
        }
        return null;
    }
    
}
[System.Serializable]
public class Inventory 
{
    public InventorySlot[] Items = new InventorySlot[10];
}
[System.Serializable]
public class InventorySlot
{
    public ItemObject item;
    public int amount;
    public InventorySlot(ItemObject _item, int _amount)
    {
        item = _item;
        amount = _amount;
    }
    public void UpdateSlot(ItemObject _item, int _amount)
    {
        item = _item;
        amount = _amount;
    }
    public void AddAmount(int value)
    {
        amount += value;
    }
    public void RemoveAmount(int value)
    {
        amount -= value;
    }

}
