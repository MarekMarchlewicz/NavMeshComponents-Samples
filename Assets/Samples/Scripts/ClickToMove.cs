using UnityEngine;
using UnityEngine.AI;

namespace AIinGames
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class ClickToMove : MonoBehaviour
    {
        NavMeshAgent m_NavMeshAgent;

        // Start is called before the first frame update
        void Start()
        {
            m_NavMeshAgent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            // When left mouse click
            if (Input.GetMouseButtonDown(0))
            {
                // Create a ray from camera position
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                // Cast a ray 100 units long
                if (Physics.Raycast(ray, out hit, 100f))
                {
                    m_NavMeshAgent.SetDestination(hit.point);
                }
            }
        }
    }
}
