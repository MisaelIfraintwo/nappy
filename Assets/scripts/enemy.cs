using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public float velocidade;

    public Transform jugador;


    private NavMeshAgent agent;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        jugador = GameObject.FindGameObjectWithTag("Player").transform;

    }

    public void Update()
    {
        agent.SetDestination(jugador.position);
    }
}
