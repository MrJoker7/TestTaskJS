using System;
using UnityEngine;
using UnityEngine.UI;

public class HandlerAnswer : MonoBehaviour
{
    public static Action<int> EventAnswer;
    public void chek()
    {
        ///<summary>
        ///Может и костыльно, но это самый адекватный вариант что пришел мне в голову, 
        ///был еще вариант упорядочить вариант в коллекцию и присваивать кнопкам соответствующие значение, 
        ///но этот вариант мне показался более практичным
        ///</summary>
        int a = int.Parse(gameObject.GetComponent<Text>().text);
        EventAnswer(a);
    }
}
