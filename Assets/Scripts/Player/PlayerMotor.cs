using UnityEngine;
using UnityEngine.AI;

namespace Player
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class PlayerMotor : MonoBehaviour
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
