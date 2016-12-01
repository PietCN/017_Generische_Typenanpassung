using System;

public class Stack<T>
{
  private Stack_Element<T> lastElement;
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
  public void Push(T element)
  {
    if (element != null)
    {
      lastElement = new Stack_Element<T>(lastElement, element);
      size++;
    }
  }
  /// <summary>
  /// Gibt das letzte Element zurück ohne dies aus dem Stack zu entfernen.
  /// </summary>
  /// <returns></returns>
  public T Piek()
  {
    if (lastElement != null)
    {
      return lastElement.element;
    }
    else
      return default(T);
  }
  /// <summary>
  /// Gibt das letzte Element zurück und entfernt dieses aus dem Stack.
  /// </summary>
  /// <returns></returns>
  public T Pop()
  {
    if (lastElement != null)
    {
      T temp = lastElement.element;
      lastElement = lastElement.previousElement;
      size--;
      return temp;
    }
    else
      return default(T);
  }

  /// <summary>
  /// Entfernt alle Elemente aus dem Stack
  /// </summary>
  public void clear()
  {
    for (Stack_Element<T> ele = lastElement; ele != null; ele = ele.previousElement)
      Pop();
  }
}
