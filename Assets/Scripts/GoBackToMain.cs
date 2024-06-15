using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToMain : MonoBehaviour
{
    AnswerContainerScript answerContainerScript;
    public void GoBack()
    {        
        SceneManager.LoadSceneAsync("MainFirst");
    }
}
