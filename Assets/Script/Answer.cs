using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    private int corectAnswer;
    private List<int> optionsAnswer = new List<int>();
    private List<int> allAnswerOptions = new List<int>();

    [Tooltip("Ссылка на отображение ответов")]
    [SerializeField] private AnswersUI answersUI;
    public void Init(int answer)
    {
        corectAnswer = answer;
        AnswerOption();
    }
    private void AnswerOption()
    {
        int min = corectAnswer - 3;
        int max = corectAnswer + 2;
        for(int i=min;i<=max; i++)
        {
            allAnswerOptions.Add(i);
        }
        allAnswerOptions.Remove(corectAnswer);
        for(int a = 0; a < 3; a++)
        {
            int randAnswer = Random.Range(0, allAnswerOptions.Count);
            optionsAnswer.Add(allAnswerOptions[randAnswer]);
            allAnswerOptions.RemoveAt(randAnswer);
        }
        optionsAnswer.Add(corectAnswer);
        answersUI.Init(optionsAnswer);
        optionsAnswer = new List<int>();
        allAnswerOptions = new List<int>();
    }
}
