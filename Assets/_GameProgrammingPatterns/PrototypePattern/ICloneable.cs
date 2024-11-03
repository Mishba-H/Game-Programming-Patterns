using UnityEngine;

namespace PrototypePattern
{
    public interface ICloneable<T>
    {
        T Clone();
    }
}