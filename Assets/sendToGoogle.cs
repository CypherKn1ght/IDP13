using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class sendToGoogle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_InputField feedback1, feedback2, feedback3, feedback4, feedback5, feedback6;
    private string URL = 
"https://docs.google.com/forms/d/e/1FAIpQLSfI4FOWvBid9jHN7ZOC2RHZPosnU8zGodhcfcvhr48AEkywZw/formResponse";

    public void Send()
    {
        StartCoroutine (Post(feedback1.text, feedback2.text, feedback3.text, feedback4.text, feedback5.text, feedback6.text));
    }

    IEnumerator Post(string DifficultyOfPuzzle1, string DifficultyOfPuzzle2, string DifficultyOfPuzzle3, string LikeAboutEscapeRoom, string DislikeAboutEscapeRoom, string Improvements)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1049668137", DifficultyOfPuzzle1);
        form.AddField("entry.1596492861", DifficultyOfPuzzle2);
        form.AddField("entry.793385333", DifficultyOfPuzzle3);
        form.AddField("entry.532365285", LikeAboutEscapeRoom);
        form.AddField("entry.1093498398", DislikeAboutEscapeRoom);
        form.AddField("entry.184862651", Improvements);
    
        UnityWebRequest www = UnityWebRequest.Post(URL, form);
       
        yield return www.SendWebRequest();

    }
}
