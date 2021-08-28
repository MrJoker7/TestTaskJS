using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UnknownPart : MonoBehaviour
{
    [Header("Необходимые ссылки")]
    [SerializeField] private Exercise exercise;
    [SerializeField] private Points points;
    [SerializeField] private TimeGame timeGame;
    private int answerInt;

    private void Start()
    {
        HandlerAnswer.EventAnswer += ChekAnswer;
        timeGame.endTime += ChekTime;
    }

    public void Init(int i)
    {
        answerInt = i;
    }

    private void ChekAnswer(int i,Image image)
    {
        StartCoroutine(CoisheColor(i, image));
    }
    private void ChekTime()
    {
        points.WrongAnswer();
        exercise.CreateExercise();
        timeGame.StartTime();
    }
    IEnumerator CoisheColor(int i, Image image)
    {
        ///<summary>
        /// при неправильном ответе, должен создаваться новый пример или просто отниматься очки
        ///</summary>
        if (i == answerInt)
        {
            points.CorectAnswer();
            image.color = new Color(0 / 255, 255 / 255, 0 / 255);
            yield return new WaitForSeconds(.5f);
            image.color = new Color(255 / 255, 255 / 255, 255 / 255);
        }
        else
        {
            points.WrongAnswer();
            image.color = new Color(255 / 255, 0 / 255, 0 / 255);
            yield return new WaitForSeconds(.5f);
            image.color = new Color(255 / 255, 255 / 255, 255 / 255);
        }
        exercise.CreateExercise();
        timeGame.StartTime();
    }
}
