using System.Numerics;

namespace ToDo;
public class NumArray1D<T> : Array1D<T>, INumArray1D<T> where T : IComparable<T>, INumber<T>
{
    public NumArray1D(int size = 10):base(size) {  }
    public NumArray1D(T[] data):base(data) { }
  
    public T? Aggregate(Func<T, T, T> fx)
    {
        if (_index == 0) return default(T);

        T result = _data[0];
        for (int i = 1; i < _index; i++)
        {
            result = fx(result, _data[i]);
        }
        return result;
    }

    public T? Max()
    {
        //ToDo
        throw new NotImplementedException();
    }

    public T? Min()
    {
        //ToDo
        throw new NotImplementedException();
    }

    public T? Product(bool IgnoreZeros = true)
    {
        //ToDo
        throw new NotImplementedException();
    }

    public T? Sum()
    {
        //ToDo
        throw new NotImplementedException();
    }
}