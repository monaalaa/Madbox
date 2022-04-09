using UnityEngine;

namespace Interfaces
{
    public interface IMovable
    {
        void MoveToPoint(Vector3 point);
        void Stop();
    }
}
