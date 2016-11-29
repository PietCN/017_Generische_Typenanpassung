using System;

class program
{
  static void Main()
  {
    Stack_Element<int> ele = new Stack_Element<int>();
    Stack_Element<string> strEle = new Stack_Element<string>();
    Stack_Element<string> strEle2 = new Stack_Element<string>();

    ele.element = 2;
    strEle.element = "Hallo";
    strEle2.element = " Welt";

    strEle.nextElement = strEle2;

    Console.WriteLine(strEle.element);
    Console.WriteLine(ele.element);

    Console.WriteLine("Iterative Ausgabe:");
    for (Stack_Element<string> i = strEle; i != null; i = i.nextElement)
      Console.WriteLine(i.element);

    Console.Read();
  }
}