using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SimplyRandomAddition : MonoBehaviour
{
    public Text firstNumber;
    public Text secondNumber;
    public TMP_Text resultOne;
    public TMP_Text resultTwo;
    public Text mathOperation;


    public Transform character; // The character's transform
    public Transform correctAnswer; // The correct answer's transform
    public TMP_Text notification; // UI Text element for notifications
    public TMP_Text correctResult; // The correct answer as a string
    public float positionTolerance = 0.1f; // Tolerance for position comparison

    // public TMP_Text notification; // UI element for notification

    public List<int> easyMathList = new List<int> (); // Initialized with sample values
    public List<string> operations = new List<string> { "+", "-", "*", "/" }; // List of operations

    private int randomFirstNumber;
    private int randomSecondNumber;
    private int firstNumberInProblem;
    private int secondNumberInProblem;
    public float correctResultNumber;

    void Start()
    {
        Debug.Log("Starting and displaying math problem.");
        DisplayMathProblem();  

        correctResultNumber = GetAnswer();
    }

    void Update()
    {
        if (Vector3.Distance(character.position, correctAnswer.position) < positionTolerance)
        {
            Debug.Log("Positions match. Checking answer...");
            CheckAnswer(correctResult.text);
        }
    }

    private void CheckAnswer(string selectedAnswer)
    {
        Debug.Log("Checking answer: " + selectedAnswer + " against correct answer: " + correctResult.text);
        if (selectedAnswer == correctResult.text)
        {
            notification.text = "Correct!";
            Debug.LogWarning("Correct answer!");
            DisplayMathProblem();
        }
        else
        {
            notification.text = "Try Again!";
            Debug.Log("Incorrect answer.");
        }
    }

    public void DisplayMathProblem()
    {
        if (easyMathList.Count == 0)
        {
            Debug.LogError("easyMathList is empty!");
            return;
        }

        // Generate random indices within the range of the list
        randomFirstNumber = Random.Range(0, easyMathList.Count);
        randomSecondNumber = Random.Range(0, easyMathList.Count);

        // Assign the random numbers from the list
        firstNumberInProblem = easyMathList[randomFirstNumber];
        secondNumberInProblem = easyMathList[randomSecondNumber];

        firstNumber.text = firstNumberInProblem.ToString();
        secondNumber.text = secondNumberInProblem.ToString();

        // Select a random operation
        string selectedOperation = operations[Random.Range(0, operations.Count)];
        mathOperation.text = selectedOperation;

        // Perform the operation
        switch (selectedOperation)
        {
            case "+":
                correctResultNumber = firstNumberInProblem + secondNumberInProblem;
                break;
            case "-":
                correctResultNumber = firstNumberInProblem - secondNumberInProblem;
                break;
            case "*":
                correctResultNumber = firstNumberInProblem * secondNumberInProblem;
                break;
            case "/":
                // Avoid division by zero
                if (secondNumberInProblem != 0)
                {
                    correctResultNumber = (float)firstNumberInProblem / secondNumberInProblem;
                }
                else
                {
                    // If division by zero, set an obvious incorrect answer
                    correctResultNumber = float.NaN;
                }
                break;
        }
        resultOne.text = correctResultNumber.ToString("0.##"); // Format to avoid too many decimals
        resultTwo.text = (correctResultNumber + 1).ToString("0.##");
    }  

    public float GetAnswer() {
         return (float)correctResultNumber;
    }
}
