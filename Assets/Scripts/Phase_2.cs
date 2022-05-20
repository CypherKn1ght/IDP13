using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Phase_2 : MonoBehaviour
{
    public int sceneBuildIndex;
    public bool tapedFingerprint = true;
    // Level moved zone enter, if collider is a player
    //Move game to another scene

    private void OnTriggerEnter2D(Collider2D other) {
        print("Trigger Entered");
        if(other.tag == "Player"){
            if(tapedFingerprint == true){
                print("Swithcing Scene to " + sceneBuildIndex);
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }
        }
    }
}
