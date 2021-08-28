using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    private Text pointText;
    private int point;

    private void Start()
    {
        pointText = GetComponent<Text>();
    }

    public void WrongAnswer()
    {
        point -= 5;
        pointText.text = point.ToString();
    }

    public void CorectAnswer()
    {
        point += 10;
        pointText.text = point.ToString();
    }
}
