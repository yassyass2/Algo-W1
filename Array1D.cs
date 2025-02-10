namespace ToDo;
public class Array1D<T> : IArray1D<T> where T : IEquatable<T>
{
    protected T[] _data=null!;
    protected int _index;
   
    public Array1D(int size = 10) { 
        _data = new T[size];
        _index = 0;
    }

    public Array1D(T[] data) { 
        //Shallow or deep copy here
        _data = data; //Shallow copy
        _index = data.Length;
    }

    public int Length => //ToDo
        throw new NotImplementedException();

    public int Count => //ToDo
        throw new NotImplementedException();

    public int Find(T Item, int startIndex = 0)
    {
        //ToDo
        throw new NotImplementedException();
    }
}