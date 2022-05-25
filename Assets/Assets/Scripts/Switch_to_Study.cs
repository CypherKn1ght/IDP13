using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Switch_to_Study : MonoBehaviour
{
    public int sceneBuildIndex;
    // Level moved zone enter, if collider is a player
    //Move game to another scene

    private void OnTriggerEnter2D(Collider2D other) {
        print("Trigger Entered");

        // Could Use other.GetComponent<Player>() to see if the game object has a Player Component
        // Tags could work too. Maybe Some players  Have different script components?
        if(other.tag == "Player"){
            //Player entered so move level
            print("Switching Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
