using UnityEngine;

public class ExercisePart : MonoBehaviour
{
    public int ExerciePartInt(int min,int max)
    {
        int i = Random.Range(min, max);
        return i;
    }
}
