using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{    
    private Transform cam;
    private Vector3 tempPos;

    [SerializeField]
    private float minX, maxX;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
    public void CamDown (){
        transform.position = new Vector3(960, 630,-10);
        Debug.Log("Down");
    }
    public void CamUp (){
        transform.position = new Vector3(960,-652,-10);
        Debug.Log("Up");

    }
}
