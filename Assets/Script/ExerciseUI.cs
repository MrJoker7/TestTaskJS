using UnityEngine;
using UnityEngine.UI;

public class ExerciseUI : MonoBehaviour
{
    [Tooltip("Ссылка на текс вопроса")]
    [SerializeField] private Text exerciseText;

    public void Init(string exercise)
    {
        exerciseText.text = exercise;
    }
}
