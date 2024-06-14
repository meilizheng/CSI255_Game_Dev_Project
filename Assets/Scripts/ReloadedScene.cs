using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ReloadedScene : MonoBehaviour
{
    public AnswerContainerScript answerContainerScript;
    public TMP_Text scoreText; // Use scoreText to differentiate from other score-related variables
    public float score;

    void Start()
    {
        // Find AnswerContainerScript in the scene
        answerContainerScript = FindObjectOfType<AnswerContainerScript>();
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
        if (answerContainerScript != null)
        {
            score = answerContainerScript.playScore;
            scoreText.text = score.ToString();
        }
        else
        {
            Debug.LogError("AnswerContainerScript or ScoreText is not assigned in the Inspector.");
        }
    }
}
