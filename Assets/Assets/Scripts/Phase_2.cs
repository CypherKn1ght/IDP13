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
    public bool hasFinger;
    [SerializeField]
    public void setFinger(bool _help)
    {
        hasFinger = _help;
    }
        private void OnTriggerEnter2D(Collider2D other)
        {
            print("Trigger Entered");
            if (other.tag == "Player") {
                if (hasFinger == true) {
                    print("Switching Scene to " + sceneBuildIndex);
                    SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
                }
            }
        }
    
}
