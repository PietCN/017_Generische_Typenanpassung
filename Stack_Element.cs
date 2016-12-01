using System;

public class Stack_Element<T>
{
  /// <summary>
  /// Initialisierungskonstruktor
  /// </summary>
  /// <param name="element"></param>
  public Stack_Element(Stack_Element<T> previous, T element)
    {
      this.element = element;
      this.previousElement = previous;
    }
  /// <summary>
  /// Kopierkonstruktor
  /// </summary>
  /// <param name="copy"></param>
  public Stack_Element(Stack_Element<T> copy)
  {
    element = copy.element;
    previousElement = copy.previousElement;
  }

  public T element;
  public Stack_Element<T> previousElement = null;
  

}