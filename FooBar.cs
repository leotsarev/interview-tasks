using System;
using System.Collections.Generic;
//Input Длинная последовательность чисел. 
//Output (для одного числа ровно одна строка)
//Если делится на 3, то "foo"
//Если делится на 5, то "bar"
//Если делится на 15, то "foobar"
//В противном случае само число, преобразованное в строку

//ВНИМАНИЕ: В задаче нет никаких подстав и попыток обмануть, напишите решение в лоб
//Если вы решаете эту задачу не в IDE — можете использовать однобуквенные имена переменных.
//Опечатки, ошибки в синтакисе и вообще все, что подскажет IDE — значения не имеют.
class Program {
  static IEnumerable<string> ConvertToFooBar(IEnumerable<int> enumerable)
  {

  }

  static void  Main() {
    var x = new [] {3,7,15};
    foreach (var s in ConvertToFooBar(x))
    {
      Console.WriteLine(s);
    }
  }

}
