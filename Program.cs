using System;

class program
{
  static void Main()
  {
    Stack<int> State = new Stack<int>();
    State.Push(new Stack_Element<int>(38));
    State.Push(new Stack_Element<int>(7));

    Console.WriteLine(State.Piek().element);
    Console.WriteLine(State.Pop().element);
    Console.WriteLine(State.Pop().element);

    Console.WriteLine(State.Count);

    Console.Read();
  }
}