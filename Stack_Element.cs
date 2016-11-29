using System;

namespace _017_Generische_Typenanpassung
{
  class Stack_Element<T>
  {
    public T element;
    public Stack_Element<T> nextElement = null;
  }
}
