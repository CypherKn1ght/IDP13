using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEditor;
using System.Runtime.Serialization;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
    public int selectedSlot;
    public string savePath;
    public ItemDatabaseObject database;
    public Inventory Container;


    public void AddItem(ItemObject _item, int _amount)
    {
        for (int i = 0; i < Container.Items.Length; i++)
        {
            if (Container.Items[i].ID == _item.Id)
            {
                Container.Items[i].AddAmount(_amount);
                return;
            }
        }
        SetEmptySlot(_item, _amount);

    }
    public InventorySlot SetEmptySlot(ItemObject _item, int _amount)
    {
        for (int i = 0; i < Container.Items.Length; i++)
        {
            if (Container.Items[i].ID <= -1)
            {
                Container.Items[i].UpdateSlot(_item.Id, _item, _amount);
                return Container.Items[i];
            }
        }
        //set up functionality for full inventory
        return null;
    }

    public void RemoveItem(ItemObject _item, int _amount)
    {
        for (int i = 0; i < Container.Items.Length; i++)
        {
            if (Container.Items[i].ID == _item.Id)
            {
                Container.Items[i].RemoveAmount(_amount);
                if (Container.Items[i].amount <= 0)
                {
                    Container.Items[i].UpdateSlot(-1, null, 0);
                }
                return;
            }
        }
    }
    public void ClearItem(ItemObject _item)
    {
        for (int i = 0; i < Container.Items.Length; i++)
        {
            if (Container.Items[i].ID == _item.Id)
            {
                Container.Items[i].UpdateSlot(-1, null, 0);
                return;
            }
        }
    }

    public bool CheckItem(ItemObject _item)
    {
        if (Container.Items[selectedSlot].item == _item)
        {
            Debug.Log("Item Exists");
            return true;
        }
        else
        {
            Debug.Log("Item Does Not Exist");
            return false;
        }
    }

    //[ContextMenu("Save")]
    //public void Save()
    //{
    //    IFormatter formatter = new BinaryFormatter();
    //    Stream stream = new FileStream(string.Concat(Application.persistentDataPath, savePath), FileMode.Create, FileAccess.Write);
    //    formatter.Serialize(stream, Container.Items);
    //    stream.Close();
    //}
    //[ContextMenu("Load")]
    //public void Load()
    //{
    //    if (File.Exists(string.Concat(Application.persistentDataPath, savePath)))
    //    {

    //        IFormatter formatter = new BinaryFormatter();
    //        Stream stream = new FileStream(string.Concat(Application.persistentDataPath, savePath), FileMode.Open, FileAccess.Read);
    //        Inventory newContainer = (Inventory)formatter.Deserialize(stream);
    //        for (int i = 0; i < Container.Items.Length; i++)
    //        {
    //            Container.Items[i].UpdateSlot(newContainer.Items[i].ID, newContainer.Items[i].item, newContainer.Items[i].amount);
    //        }
    //        stream.Close();
    //    }
    //}
    [ContextMenu("Clear")]
    public void Clear()
    {
        Container = new Inventory();
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
    public int ID = -1;
    public ItemObject item;
    public int amount;
    public InventorySlot()
    {
        ID = -1;
        item = null;
        amount = 0;
    }
    public InventorySlot(int _id, ItemObject _item, int _amount)
    {
        ID = _id;
        item = _item;
        amount = _amount;
    }
    public void UpdateSlot(int _id, ItemObject _item, int _amount)
    {
        ID = _id;
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