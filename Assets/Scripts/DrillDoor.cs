using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillDoor : MonoBehaviour
{
    private bool part1 = false;
    private bool part2 = false;
    private bool part3 = false;
    private bool part4 = false;
    public void setPart1(bool b)
    {
        part1 = b;
    }
    public void setPart2(bool b)
    {
        part2 = b;
    }
    public void setPart3(bool b)
    {
        part3 = b;
    }
    public void setPart4(bool b)
    {
        part4 = b;
    }
    public bool checkDrill()
    {
        if (part1 && part2 && part3 && part4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
