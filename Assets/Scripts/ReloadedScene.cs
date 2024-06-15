using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ReloadedScene : MonoBehaviour
{
    public AnswerContainerScript answerContainerScript;
    public TMP_Text scoreText; // Use scoreText to differentiate from other score-related variables
    public static float score;

    void Start()
    {        
        UpdateScoreText();
    }

    public void ReloadScene()
    {
        // Reload the current active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    private void UpdateScoreText()
    {
        // Update score text component with current playScore
        if (scoreText != null)
        {
            scoreText.text = AnswerContainerScript.playScore.ToString();
        }
        else
        {
            Debug.LogError("ScoreText is not assigned in the Inspector.");
        }if (scoreText != null)
        {
            scoreText.text = AnswerContainerScript.playScore.ToString();
        }
        else
        {
            Debug.LogError("ScoreText is not assigned in the Inspector.");
        }
    }
}
