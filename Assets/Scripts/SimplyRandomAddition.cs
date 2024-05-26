using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimplyRandomAddition : MonoBehaviour
{
    public Text firstNumber;
    public Text secondNumber;
    public List<int> easyMathLish = new List<int>();
    public int randomFirstNumber;
    public int randomSecondNumber;

    int firstNumberInProblem;
    int secondNumberInProblem;
    // Start is called before the first frame update
    private void Start()
    {
        DisplayMathProblem();
    }

    public void DisplayMathProblem()
    {
        //generate a random number as the first and second number
        randomFirstNumber = Random.Range(0, easyMathLish.Count + 1);
        randomSecondNumber = Random.Range(0,easyMathLish.Count + 1);
        //assing the first and second number
        firstNumberInProblem = randomFirstNumber;
        secondNumberInProblem = randomSecondNumber;
        //this is where you can either addition, subtraction, multiplication or division
        // answerOne = firstNumberInProblem + secondNumberInProblem;
        // displayRandowAnswer = Random.Range(0, 2);
        // if(displayRandowAnswer == 0)
        // {
        //     answerTwo = answerOne + Random.Range(1, 5);
        // }
        // else
        // {
        //     answerTwo = answerOne - Random.Range(1, 5);    
        // }

        firstNumber.text ="" + firstNumberInProblem;
        secondNumber.text ="" + secondNumberInProblem;
        // randomAnswerPlacement = Random.Range(0, 2);
        // if(randomAnswerPlacement == 0)
        // {
        //     answer1.text = "" + answerOne;
        //     answer2.text = "" + answerTwo;
        //     currentAnswer = 0;
        // }
        // else
        // {
        //     answer1.text = "" + answerTwo;
        //     answer2.text = "" + answerOne;
        //     currentAnswer = 1;
        // }
    }
}
