using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_Collided : MonoBehaviour
{
    public bool weaponTrue = false;
    public bool enabled;
    void Start()
    {
        print("Code For Bot Is Running");
    }

    private static OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (weaponTrue == true){
                print("Hey! What are you doing?!? Wait, get away from me!!! AHHHHHHH!!!");
                yield return new WaitForSeconds(2f);
                Collider2D.enabled = false;
            }
            else{
                print("Hey!!! Get out of here, you do not have access!");
            }
        }
    }
}
