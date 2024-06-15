using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AnswerContainerScript : MonoBehaviour
{
    public TMP_Text boxAnswer;
    SimplyRandomAddition sra;

    AnswerContainerScript answerContainerScript;
    public TMP_Text score;           
    public static float playScore = 0;

    private void Start() {
        sra = FindObjectOfType<SimplyRandomAddition>();
        Debug.Log("Correct Answer: " + sra.GetAnswer());
    }

    private void OnCollisionEnter(Collision other) {

        if(other.gameObject.tag == "Player") {

            if( float.Parse(boxAnswer.text) == sra.correctResultNumber){
                sra.notification.text = "Correct Answer ";
                playScore += 100;
                score.text = playScore.ToString();
            }
            if (float.Parse(boxAnswer.text) != sra.correctResultNumber){
                sra.notification.text = "Please try again";
            }                       
        }               
   }
}