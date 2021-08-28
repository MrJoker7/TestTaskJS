using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    [SerializeField] private Text pointText;
    private int point;

    public void WrongAnswer()
    {
        point -= 5;
        pointText.text = "Количество очков: " + point.ToString();
    }

    public void CorectAnswer()
    {
        point += 10;
        pointText.text = "Количество очков: " + point.ToString();
    }
}
