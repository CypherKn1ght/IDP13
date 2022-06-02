using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDeleteOnLoad : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
