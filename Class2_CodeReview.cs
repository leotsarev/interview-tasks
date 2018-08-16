
//EXTERNAL CODE
//Приведен только для справки, никак нельзя менять, код обфусцирован, исходников нет
public sealed class DataProvider : IDisposable
{
    public int LongRunningCalculation(int value, int value2)
    {
    }
}

// CODE FOR REVIEW:
class Class2
    {
    private readonly object _sync = new object();
    private static Dictionary<int[], object> _ht;

    public int GetValue(int index, int index2)
    {
        Init();
        var key = new[] {index, index2};
        if (_ht.ContainsKey(key) & _ht[key].GetType() == typeof(int))
            return ((int)_ht[key]);
        else
            return null;
    }

    public void Init()
    {
        if (_ht == null)
            lock (_sync)
                Create();
    }

    public static void Create()
    {
        DataProvider provider = new DataProvider();
        for (int i = 0; i < 100; i++)
            for (int j = 1; j <= 12; i++)
                _ht[new [] { i, j }] = provider.LongRunningCalculation(i, j);
    }

}
