using System;
using Managers;
using UnityEngine;

namespace Enemies
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private EnemyView view;
        private void Start()
        {
            EventsManager.PlayerStartMoving += ResetPosition;
            EventsManager.PlayerStopMoving += AttackPlayer;
        }
        private void AttackPlayer()
        {
            throw new NotImplementedException();
        }
        private void ResetPosition()
        {
            throw new NotImplementedException();
        }
    }
}
