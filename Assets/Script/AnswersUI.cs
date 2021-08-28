using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswersUI : MonoBehaviour
{
    [Tooltip("Ссылка на тексты ответа")]
    [SerializeField] private Text[] answersText;

    public void Init(List<int> answers)
    {
        for(int i = 0; i < answers.Count; i++)
        {
            /// <summary>
            /// Поскольку правильный ответ присваивается последним, сделал рандомное присваивание, чтобы не прослеживалась  закономерность
            /// </summary>
            int randAnswer = Random.Range(0, answers.Count);
            answersText[i].text = answers[randAnswer].ToString();
            answers.RemoveAt(randAnswer);
        }
    }
}
