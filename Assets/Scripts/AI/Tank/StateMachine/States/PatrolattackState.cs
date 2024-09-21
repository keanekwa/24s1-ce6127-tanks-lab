using System.Collections;
using UnityEngine;

using Random = UnityEngine.Random;
using Debug = UnityEngine.Debug;

namespace CE6127.Tanks.AI
{
    /// <summary>
    /// Class <c>PatrollingState</c> represents the state of the tank when it is patrolling.
    /// </summary>
    internal class PatrolattackState : BaseState
    {
        private TankSM m_TankSM;        // Reference to the tank state machine.
        private Vector3 m_Destination;  // Destination for the tank to move to.
        private float timer = 0;

        /// <summary>
        /// Constructor <c>PatrollingState</c> constructor.
        /// </summary>
        public PatrolattackState(TankSM tankStateMachine) : base("Patrolattack", tankStateMachine) => m_TankSM = (TankSM)m_StateMachine;

        /// <summary>
        /// Method <c>Enter</c> on enter.
        /// </summary>
        public override void Enter()
        {
            base.Enter();

            m_TankSM.SetStopDistanceToZero();

            m_TankSM.StartCoroutine(Patrolattack());
        }

        /// <summary>
        /// Method <c>Update</c> update logic.
        /// </summary>
        public override void Update()
        {
            // Debug.Log("Helooooo"+ m_TankSM.Target.position);
            base.Update();
            var currHealth = m_TankSM.TankHealthCu();
            if (m_TankSM.Target != null)
            {
                var dist = Vector3.Distance(m_TankSM.transform.position, m_TankSM.Target.position);
                if (dist <= m_TankSM.StopDistance) // ... Obviously this doesn't make much sense, but it's just for demonstration purposes.
                    m_StateMachine.ChangeState(m_TankSM.m_States.Attack);
                else if (dist <= m_TankSM.TargetDistance) // ... Obviously this doesn't make much sense, but it's just for demonstration purposes.
                    m_StateMachine.ChangeState(m_TankSM.m_States.Patrolling);
                else if (currHealth <= 15)
                    m_StateMachine.ChangeState(m_TankSM.m_States.Runaway);
            }

            if (Time.time >= m_TankSM.NavMeshUpdateDeadline)
            {
                m_TankSM.NavMeshUpdateDeadline = Time.time + m_TankSM.PatrolNavMeshUpdate;                
                m_TankSM.NavMeshAgent.SetDestination(m_Destination);
            }
            var distanceTarget = Mathf.Sqrt(Mathf.Pow(m_TankSM.Target.position.x - m_TankSM.transform.position.x,2)+Mathf.Pow(m_TankSM.Target.position.z - m_TankSM.transform.position.z,2));
            
            //Debug.Log("Tank position"+distanceTarget+"or"+m_TankSM.TargetDistance);
            var force = 2.3f + (18.5f*distanceTarget/22.0f);
            force = Mathf.Min(Mathf.Max(force,m_TankSM.LaunchForceMinMax.x),m_TankSM.LaunchForceMinMax.y);
            //Debug.Log("State Achieved");
            var forceProj = force;
            var timeCool = 0.2f + (1.8f*forceProj/23.5f);
            if (timer < timeCool)
            {
                timer += Time.deltaTime;
                
            }
            else
            {
                m_TankSM.LaunchProjectile(forceProj);
                timer = 0;
            }
        }

        /// <summary>
        /// Method <c>Exit</c> on exiting PatrollingState.
        /// </summary>
        public override void Exit()
        {
            base.Exit();

            m_TankSM.StopCoroutine(Patrolattack());
        }

        /// <summary>
        /// Coroutine <c>Patrolling</c> patrolling coroutine.
        /// </summary>
        IEnumerator Patrolattack()
        {
            while (true)
            {
                
                m_Destination = m_TankSM.Target.position;
                float waitInSec = Mathf.Min(m_TankSM.PatrolWaitTime.x, m_TankSM.PatrolWaitTime.y);
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
