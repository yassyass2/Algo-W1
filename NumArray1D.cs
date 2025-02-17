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
        if (_index == 0) return default(T);
        T result = _data[0];
        for (int i = 1; i < _index; i++)
        {
            if (_data[i] > result){
                result = _data[i];
            }
        }
        return result;
    }

    public T? Min()
    {
        if (_index == 0) return default(T);
        T result = _data[0];
        for (int i = 1; i < _index; i++)
        {
            if (_data[i] < result){
                result = _data[i];
            }
        }
        return result;
    }

    public T? Product(bool IgnoreZeros = true)
    {
        if (_index == 0) return default(T);
        T result = T.One;
        for (int i = 0; i < _index; i++)
        {
            if (IgnoreZeros && _data[i] == T.Zero){
                continue;
            }
            result = result * _data[i];
        }
        return result;
    }

    public T? Sum()
    {
        if (_index == 0) return default(T);
        T result = _data[0];
        for (int i = 1; i < _index; i++)
        {
            result += _data[i];
        }
        return result;
    }
}