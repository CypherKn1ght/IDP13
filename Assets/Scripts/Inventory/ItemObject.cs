using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class ItemObject : ScriptableObject
{
    public int Id;
    public Sprite uiDisplay;
    [TextArea(15,20)]
    public string description;
}

[Serializable]
public class Item
{
    public string Name;
    public int Id;
    public Item(ItemObject item)
    {
        Name = item.name;
        Id = item.Id;
    }
}