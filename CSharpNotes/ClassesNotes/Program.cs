using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest a = new Forest("Amazon");
      Console.WriteLine(a.Trees);
      a.Grow();
      Console.WriteLine(a.Trees);

    }
  }
}
