using System;

namespace FactoryPattern
{
    public static class Factory
    {
        public static object Creator<T>()
        {
            if (typeof(T) == typeof(int))
            {
                return 42;
            }
            else if (typeof(T).Equals(typeof(double)))
            {
                return 42.3;
            }
            else if (typeof(T).Equals(typeof(MyClass)))
            {
                return new MyClass() { Id = 1 };
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
