using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToMain : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadSceneAsync("MainFirst");
    }
}