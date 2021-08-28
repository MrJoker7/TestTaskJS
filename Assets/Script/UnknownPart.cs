using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnknownPart : MonoBehaviour
{
    [SerializeField] private Exercise exercise;
    [SerializeField] private Points points;
    private int answerInt;

    private void Start()
    {
        HandlerAnswer.EventAnswer += ChekAnswer;
    }

    public void Init(int i)
    {
        answerInt = i;
    }

    private void ChekAnswer(int i)
    {
        ///<summary>
        /// при неправильном ответе, должен создаваться новый пример или просто отниматься очки
        ///</summary>
        if (i == answerInt) points.CorectAnswer();
        else points.WrongAnswer();
        exercise.CreateExercise();
    }

}
