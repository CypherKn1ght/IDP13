using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class urlbutton : MonoBehaviour{
  public void OnTriggerEnter2D(Collider2D other){
    if (other.CompareTag("Player")){
      Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSfI4FOWvBid9jHN7ZOC2RHZPosnU8zGodhcfcvhr48AEkywZw/viewform");   
      Debug.Log("It Works?");
    }
  }
}
