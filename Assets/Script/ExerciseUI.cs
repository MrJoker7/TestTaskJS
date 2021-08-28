using UnityEngine;
using UnityEngine.UI;

public class ExerciseUI : MonoBehaviour
{
    [SerializeField]private Text exerciseText;

    private void Start()
    {
        ///<summary>
        ///Не знаю почему, но при первом запуске выдавало ошибку, по этому я присвоил через испектор
        ///</summary>
        //exerciseText = GetComponent<Text>();
    }

    public void Init(string exercise)
    {
        exerciseText.text = exercise;
    }
}
