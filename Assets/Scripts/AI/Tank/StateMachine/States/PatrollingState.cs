using System.Collections;
using UnityEngine;

using Random = UnityEngine.Random;
using Debug = UnityEngine.Debug;

namespace CE6127.Tanks.AI
{
    /// <summary>
    /// Class <c>PatrollingState</c> represents the state of the tank when it is patrolling.
    /// </summary>
    internal class PatrollingState : BaseState
    {
        private TankSM m_TankSM;        // Reference to the tank state machine.
        private Vector3 m_Destination;  // Destination for the tank to move to.

        private Vector2 ra = new(5,-5);

        /// <summary>
        /// Constructor <c>PatrollingState</c> constructor.
        /// </summary>
        public PatrollingState(TankSM tankStateMachine) : base("Patrolling", tankStateMachine) => m_TankSM = (TankSM)m_StateMachine;

        /// <summary>
        /// Method <c>Enter</c> on enter.
        /// </summary>
        public override void Enter()
        {
            base.Enter();

            m_TankSM.SetStopDistanceToZero();

            m_TankSM.StartCoroutine(Patrolling());
        }

        /// <summary>
        /// Method <c>Update</c> update logic.
        /// </summary>
        public override void Update()
        {
            // Debug.Log("Helooooo"+ m_TankSM.Target.position);
            base.Update();
            if (m_TankSM.Target != null)
            {
                var dist = Vector3.Distance(m_TankSM.transform.position, m_TankSM.Target.position);
                if (dist <= m_TankSM.StopDistance) // ... Obviously this doesn't make much sense, but it's just for demonstration purposes.
                    m_StateMachine.ChangeState(m_TankSM.m_States.Attack);
                else if (dist < m_TankSM.TargetDistance)
                    m_StateMachine.ChangeState(m_TankSM.m_States.Patrolattack);
            }

            if (Time.time >= m_TankSM.NavMeshUpdateDeadline)
            {
                m_TankSM.NavMeshUpdateDeadline = Time.time + m_TankSM.PatrolNavMeshUpdate;                
                m_TankSM.NavMeshAgent.SetDestination(m_Destination);
            }
        }

        /// <summary>
        /// Method <c>Exit</c> on exiting PatrollingState.
        /// </summary>
        public override void Exit()
        {
            base.Exit();

            m_TankSM.StopCoroutine(Patrolling());
        }

        float GetRandomElementFromVector2(Vector2 vector)
        {
            // Initialize the random generator
            System.Random random = new System.Random();

            // Randomly choose either x (0) or y (1)
            int randomIndex = random.Next(0, 2);

            // Return x if randomIndex is 0, else return y
            return randomIndex == 0 ? vector.x : vector.y;
        }


        /// <summary>
        /// Coroutine <c>Patrolling</c> patrolling coroutine.
        /// </summary>
        IEnumerator Patrolling()
        {
            while (true)
            {
                m_Destination = m_TankSM.Target.position;
                // float randomElement = GetRandomElementFromVector2(ra);
                // m_Destination.x = m_Destination.x - randomElement;
                // float randomElement1 = GetRandomElementFromVector2(ra);
                // m_Destination.z = m_Destination.z - randomElement1;
                //float waitInSec = Mathf.Min(m_TankSM.PatrolWaitTime.x, m_TankSM.PatrolWaitTime.y);
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
