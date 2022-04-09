using UnityEngine;

namespace Movables
{
    public interface IMovable
    {
        void MoveToPoint(Vector3 point);
        void Stop();
    }
}
