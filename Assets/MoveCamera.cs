using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MoveCamera : MonoBehaviour
{
    GameObject gameObjectToMove;
    public int x;
    public int y;
    public int z;
    void MoveGameObject()
    {
        gameObjectToMove.transform.position = new Vector3(x, y, z);
    }
}