using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : MonoBehaviour
{
    private ExercisePart exercisePartOne = new ExercisePart();
    private ExercisePart exercisePartTwo = new ExercisePart();
    private Actions[] action = new Actions[3];

    private float answerInt;
    private int one;
    private int two;
    private int randomAction;
    private int unkownInt;
    private string actionStr(int a)
    {
        string act = null;
        switch (a)
        {
            case 0:
                act = "+";
                break;
            case 1:
                act = "-";
                break;
            case 2:
                act = "*";
                break;
        }
        return act;
    }
    private string AnswerStr(int i)
    {
        string str = null;
        switch (i)
        {
            case 0:
                str = "? " + actionStr(randomAction) + " " + two.ToString() + " = " + answerInt.ToString();
                break;
            case 1:
                str = one.ToString() + actionStr(randomAction) + " ? " + " = " + answerInt.ToString();
                break;
            case 2:
                str = one.ToString() + actionStr(randomAction) + " " + two.ToString() + " = ?"; 
                break;
        }
        return str;

    }
    public float AnswerInt
    {
        get { return answerInt; }
    }

    [Header("Необходимые ссылки")]
    [SerializeField] private UnknownPart unknown;
    [SerializeField] private ExerciseUI exerciseUI;
    [SerializeField] private Answer answer;
    private void Start()
    {
        action[0] = new Addition();
        action[1] = new Subtraction();
        action[2] = new Multiplication();
        CreateExercise();
    }
    public void CreateExercise()
    {
        randomAction = Random.Range(0, action.Length);
        ///<summary>
        ///задал такой маленький диапазон, потому что при умножении получаются слишком большие числа
        ///</summary>
        one = exercisePartOne.ExerciePartInt(3, 9);
        two = exercisePartTwo.ExerciePartInt(3, 9);
        answerInt = action[randomAction].Answer(one, two);
        UnknownPart();
    }

    private void UnknownPart()
    {
        int randUnkown = Random.Range(0, 2);
        switch (randUnkown)
        {
            case 0:
                unkownInt = one;
                break;
            case 1:
                unkownInt = two;
                break;
            case 2:
                unkownInt = (int)answerInt;
                break;
        }
        unknown.Init(unkownInt);
        exerciseUI.Init(AnswerStr(randUnkown));
        answer.Init(unkownInt);
    }
}
