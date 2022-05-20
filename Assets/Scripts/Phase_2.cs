using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase_2 : MonoBehaviour
{
    public int sceneBuildIndex;
    public bool tapedFingerprint = True;
    // Level moved zone enter, if collider is a player
    //Move game to another scene

    private void OnTriggerEnter2D(Collider2D other) {
        print("Trigger Entered");
        if(other.tag == "Player")&(tapedFingerprint == True){
            print("Swithcing Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
