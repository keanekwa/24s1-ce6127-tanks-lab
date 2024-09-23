using UnityEngine;

using Debug = UnityEngine.Debug;

namespace CE6127.Tanks.AI
{
    /// <summary>
    /// Class <c>IdleState</c> represents the state of the tank when it is idle.
    /// </summary>
    internal class AttackState : BaseState
    {
        private TankSM m_TankSM; // Reference to the tank state machine.

        /// <summary>
        /// Constructor <c>IdleState</c> is the constructor of the class.
        /// </summary>
        public AttackState(TankSM tankStateMachine) : base("Attack", tankStateMachine) => m_TankSM = (TankSM)m_StateMachine;

        /// <summary>
        /// Method <c>Enter</c> is called when the state is entered.
        /// </summary>
        public override void Enter() => base.Enter();
        private float timer = 0;
        private float attacktimer = 0;
        /// <summary>
        /// Method <c>Update</c> is called each frame.
        /// </summary>
        public override void Update()
        {
            base.Update();

            if (m_TankSM.Target != null)
            {
                var currHealth = m_TankSM.TankHealthCu();
                attacktimer += Time.deltaTime;
                var dist = Vector3.Distance(m_TankSM.transform.position, m_TankSM.Target.position);
                if (attacktimer > 2.0f)
                {
                    m_StateMachine.ChangeState(m_TankSM.m_States.Patrolling);
                    attacktimer = 0;
                }
                else if (dist > m_TankSM.TargetDistance)
                    m_StateMachine.ChangeState(m_TankSM.m_States.Patrolling);
                else if (dist > m_TankSM.StopDistance)
                    m_StateMachine.ChangeState(m_TankSM.m_States.Patrolattack);
                else if (currHealth <= 20)
                    m_StateMachine.ChangeState(m_TankSM.m_States.Runaway);
                // ... Just for demonstration purposes; more to be implemented.
            }

            var lookPos = m_TankSM.Target.position - m_TankSM.transform.position;
            lookPos.y = 0f;
            var rot = Quaternion.LookRotation(lookPos);
            m_TankSM.transform.rotation = Quaternion.Slerp(m_TankSM.transform.rotation, rot, m_TankSM.OrientSlerpScalar);


            var distanceTarget = Mathf.Sqrt(Mathf.Pow(m_TankSM.Target.position.x - m_TankSM.transform.position.x,2)+Mathf.Pow(m_TankSM.Target.position.z - m_TankSM.transform.position.z,2));
            
            //Debug.Log("Tank position"+distanceTarget+"or"+m_TankSM.TargetDistance);
            var force = 2.3f + (18.5f*distanceTarget/22.0f);
            force = Mathf.Min(Mathf.Max(force,m_TankSM.LaunchForceMinMax.x),m_TankSM.LaunchForceMinMax.y);
            //Debug.Log("Tank force"+distanceTarget);
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

    }
}
