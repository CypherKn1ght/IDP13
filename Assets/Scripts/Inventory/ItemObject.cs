using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class ItemObject : ScriptableObject
{
    public int Id;
    public Sprite uiDisplay;
    [TextArea(15,20)]
    public string description;
}
