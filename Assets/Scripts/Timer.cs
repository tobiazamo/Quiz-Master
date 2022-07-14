using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToAnsweQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool loadNextQuestion;
    public float fillFraction;

    public bool isAnsweringQuestion;

    float timerValue;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if(isAnsweringQuestion)
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToAnsweQuestion;

            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;

            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToAnsweQuestion;
                loadNextQuestion = true;
            }
        }
    }
}
