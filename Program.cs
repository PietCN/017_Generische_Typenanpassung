using System;

class program
{
  static void Main()
  {
    Stack<int> State = new Stack<int>();
    State.Push(38);
    State.Push(7);
    State.Push(19);
    State.Push(105);
    State.Push(47);

    Console.WriteLine(State.Piek());
    Console.WriteLine(State.Pop());
    Console.WriteLine(State.Pop());
    Console.WriteLine(State.Pop());

    Console.WriteLine(State.Count);

    State.clear();
    Console.WriteLine(State.Count);

    Console.Read();
  }
}