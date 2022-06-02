using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UIElements;
using System;


public class DrillDoor : MonoBehaviour
{
    public InventoryObject inventory;
    private bool part1 = false;
    private bool part2 = false;
    private bool part3 = false;
    private bool part4 = false;
    List<bool> parts = new List<bool>();
    private void Start()
    {
        parts.Add(part1);
        parts.Add(part2);
        parts.Add(part3);
        parts.Add(part4);
    }
    //public Image image1;
    //public Image image2;
    //public Image image3;
    //public Image image4;
    //public void setPart1(bool b)
    //{
    //    part1 = b;
    //}
    //public void setPart2(bool b)
    //{
    //    part2 = b;
    //}
    //public void setPart3(bool b)
    //{
    //    part3 = b;
    //}
    //public void setPart4(bool b)
    //{
    //    part4 = b;
    //}
    //public bool getPart1()
    //{
    //    return part1;
    //}
    //public bool getPart2()
    //{
    //    return part2;
    //}
    //public bool getPart3()
    //{
    //    return part3;
    //}
    //public bool getPart4()
    //{
    //    return part4;
    //}
    //public bool checkDrill()
    //{
    //    if (part1 && part2 && part3 && part4)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
    public void setDrill(int ID)
    {
        for (int i = 0; i < inventory.Container.Items.Length; i++)
        {
            if (inventory.Container.Items[i] != null)
            {
                if (inventory.Container.Items[i].ID == ID)
                {
                    parts[ID - 2] = true;
                }
            }
        }
    }
    public bool checkDrill()
    {
        for (int i = 0; i < parts.Count; i++)
        {
            if (!parts[i])
            {
                return false;
            }
        }
        return true;
    }
}
