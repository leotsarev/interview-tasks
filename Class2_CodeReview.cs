CODE FOR REVIEW:
class Class2
    {
        private readonly object _sync = new object();
        private static System.Collections.Hashtable _ht;

        public int GetValue(int index)
        {
            Init();
            return (int)_ht["name_" + index];
        }


        public void Init()
        {
            if (_ht == null)
                lock (_sync)
                    if (_ht == null)
                        Create();
        }


        public static void Create()
        {
            DataProvider provider = new DataProvider();
            for (int i = 0; i < 100; i++)
                _ht["name_" + i] = provider.LongRunningCalculation(i);
        }

    }

EXTERNAL CODE

public class DataProvider : IDisposable
{
    public int LongRunningCalculation(int value)
       {
           ....
       }
}
