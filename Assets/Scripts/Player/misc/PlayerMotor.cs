using Movables;
using UnityEngine;
using UnityEngine.AI;

namespace Player.misc
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class PlayerMotor : MonoBehaviour,IMovable
    {
        [SerializeField] private NavMeshAgent agent;

        public void MoveToPoint(Vector3 point)
        {
            agent.isStopped = false;
            agent.SetDestination(point);
        }

        public void Stop()
        {
            agent.isStopped = true;
        }
    }
}
