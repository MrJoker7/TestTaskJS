
interface Actions
{
    /// <summary>
    /// этот способ подойдет для любых манипуляции с двумя числа(деление, остаток), но для более сложных придется создавать новый класс
    /// </summary>
    float Answer(int one, int two);
}

public struct Addition : Actions
{
    public float Answer(int one, int two)
    {
        int result = one + two;
        return result;
    }
}

public struct Subtraction : Actions
{
    public float Answer(int one, int two)
    {
        /// <summary>
        /// если ответ не может быть отрицательным, то можно сделать проверку
        /// </summary>
        int result = one - two;
        return result;
    }
}

public struct Multiplication : Actions
{
    public float Answer(int one, int two)
    {
        int result = one * two;
        return result;
    }
}