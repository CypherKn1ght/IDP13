using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bot_Collided : MonoBehaviour
{
    public bool weaponTrue = false;
    public bool enabled;
    public bool colliderActive = true;
    public int sceneBuildIndex;
    void Start()
    {
        print("Code For Bot Is Running");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        { 
            if (weaponTrue == true){
                print("Hey! What are you doing?!? Wait, get away from me!!! AHHHHHHH!!!");
                colliderActive = false;
            }
            else{
                print("Hey!!! Get out of here, you do not have access!");
            }
            
        }
        
    }
    private IEnumerator OnTriggerStay2D(Collider2D col){
        if (colliderActive == false){
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
