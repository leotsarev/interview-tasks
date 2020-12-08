using System;
using System.Collections.Generic;

//EXTERNAL CODE
//Приведен только для справки, никак нельзя менять, код обфусцирован, исходников нет
public sealed class DataProvider : IDisposable
{
    public extern int LongRunningCalculation(int value, int value2);
    public extern void Dispose();
}

// CODE FOR REVIEW:
class Class2
{
        
    private class ListEntry
    {
        int[] Key {get; set;}
        int Value {get;set;}
    }
    private readonly object _sync = new object();
    private static List<int[], int> list;

    public int GetValue(int index, int index2)
    {
        Init();
        var key = new[] {index, index2};
        if (list.Any(x => x.Key == key))
            return list.SingleOrDefault(x => x.Key == key);
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
            for (int j = 1; j <= 12; j++)
                list.Add(new ListEntry {Key = new [] { i, j }, Value = provider.LongRunningCalculation(i, j)});
    }

}

// Usage of Class2 (если возникают вопросы как используется)
class WebController
{
    // Старая версия до наших изменений
    public ActionResult<int> RequestValue(int index, int index2)
    {
        var dataProvider = new DataProvider();
        return Ok(dataProvider.GetValue(index, index2));
    }

    // Новая версия после наших изменений
    public ActionResult<int> RequestValue(int index, int index2)
    {
        var cl2 = new Class2();
        return Ok(cl.GetValue(index, index2));
    }
}

