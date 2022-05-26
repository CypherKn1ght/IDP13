using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemObject : ScriptableObject
{
    public Sprite uiDisplay;
    [TextArea(15,20)]
    public string description;
}
