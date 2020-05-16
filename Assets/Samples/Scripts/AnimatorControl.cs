using UnityEngine;
using UnityEngine.AI;

namespace AIinGames
{
    [RequireComponent(typeof(Animator), typeof(NavMeshAgent))]
    public class AnimatorControl : MonoBehaviour
    {
        Animator m_Animator;

        NavMeshAgent m_NavMeshAgent;

        readonly int m_SpeedAnimId = Animator.StringToHash("Speed");

        // Start is called before the first frame update
        void Start()
        {
            m_Animator = GetComponent<Animator>();
            m_NavMeshAgent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void LateUpdate()
        {
            var currentSpeed = m_NavMeshAgent.velocity.magnitude;
            m_Animator.SetFloat(m_SpeedAnimId, currentSpeed);
        }
    }
}
