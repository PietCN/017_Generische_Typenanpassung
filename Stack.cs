using System;

public class Stack<T>
{
  private Stack_Element<T> lastElement = null;
  private uint size = 0;

  /// <summary>
  /// Gibt die momentane Größe des Stackes an
  /// </summary>
  public uint Count
  {
    get
    {
      return size;
    }
  }

  /// <summary>
  /// Fügt ein Element am Ende des Stackes ein.
  /// </summary>
  /// <param name="element"></param>
  public void Push(Stack_Element<T> element)
  {
    if (lastElement == null)
      lastElement = element;
    else
    {
      element.previousElement = lastElement;
      lastElement = element;
    }
    size++;
  }
  /// <summary>
  /// Gibt das letzte Element zurück ohne dies aus dem Stack zu entfernen.
  /// </summary>
  /// <returns></returns>
  public Stack_Element<T> Piek()
  {
    if (lastElement != null)
    {
      Stack_Element<T> temp = new Stack_Element<T>(lastElement);
      temp.previousElement = null;
      return temp;
    }
    else
      return null;
  }
  /// <summary>
  /// Gibt das letzte Element zurück und entfernt dieses aus dem Stack.
  /// </summary>
  /// <returns></returns>
  public Stack_Element<T> Pop()
  {
    if (lastElement != null)
    {
      Stack_Element<T> temp = new Stack_Element<T>(lastElement);
      if (lastElement.previousElement == null)
      {
        lastElement = null;
      }
      else
      {
        temp.previousElement = null;
        lastElement = lastElement.previousElement;
      }
      size--;
      return temp;
    }
    else
      return null;
  }

  /// <summary>
  /// Entfernt alle Elemente aus dem Stack
  /// </summary>
  public void clear()
  {
    for (Stack_Element<T> ele = lastElement; ele.previousElement != null; ele = ele.previousElement)
      Pop();
  }
}
