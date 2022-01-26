using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombiMove : MonoBehaviour
{
    //Variables para el NaveMeshAgent
    float zombiSpeed;
    Vector3 goal;
    //Componente
    NavMeshAgent agent;

    //Variables para la detecci�n del jugador
    Transform player; //posicion del jugador
    bool detected; //variable que determina si me han detectado
    [SerializeField] float visionRange = 10f; //Distancia a la que me ha detectado
    [SerializeField] float visionConeAngle = 60f; //Angulo de vision
    float goalDistance;

    //Animator
    Animator animator;

    //Variable de la corrutina
    bool haciendoRonda;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Survivor").transform;

        animator = GetComponent<Animator>();

        //Inicio la ronda
        StartCoroutine("Ronda");

        goal = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Detectar();


        if (goal != null)
        {
            goalDistance = Vector3.Distance(transform.position, goal);

            if (goalDistance > 0.9f && !detected)
            {
                animator.SetBool("Walk", true);
            }
            else if (goalDistance > 0.9f && detected)
            {
                animator.SetBool("Run", true);
                animator.SetBool("Walk", false);
            }
            else
            {
                if (detected)
                {
                    animator.SetBool("Atack", true);
                }
                else
                {
                    animator.SetBool("Walk", false);
                    animator.SetBool("Run", false);
                }

            }
            //print(goalDistance);
        }

        if (detected)
        {
            print(goalDistance);
            if (goalDistance > 0.7)
            {
                agent.speed = 4f;
            }
            else
            {
                agent.speed = 0f;
            }
            goal = player.position;

            agent.SetDestination(goal);

        }


    }


    Vector3 SetRandomGoal(Vector3 zombiPos, float randomValue = 5f)
    {

        Vector3 returnPos;

        float newX = zombiPos.x + Random.Range(-randomValue, randomValue);
        float newZ = zombiPos.z + Random.Range(-randomValue, randomValue);

        returnPos = new Vector3(newX, zombiPos.y, newZ);

        return returnPos;
    }

    void Detectar()
    {
        //Creamos un Vector3 con la posición del jugador, y otro entre nosotros y él
        Vector3 playerPosition = player.position;
        Vector3 vectorToPlayer = playerPosition - transform.position;

        //Distancia hasta el jugador y angulo que forma nuestra vision frontal con el
        //Si es una IA, podemmos con navMeshAgent, podemos usar remainingDistance
        float distanceToPlayer = Vector3.Distance(transform.position, playerPosition);
        float angleToPlayer = Vector3.Angle(transform.forward, vectorToPlayer);
        //Si está en mi rango y en mi ángulo de visión
        if (distanceToPlayer <= visionRange && angleToPlayer <= visionConeAngle)
        {
            //print("Me han pillado");
            detected = true;
            if (distanceToPlayer < 5)
            {
                visionConeAngle = 360;
            }
            else
            {
                visionConeAngle = 60;
            }

            if (haciendoRonda)
            {
                StopCoroutine("Ronda");
                haciendoRonda = false;
            }


        }
        else
        {

            detected = false;
            if (!haciendoRonda)
            {
                StartCoroutine("Ronda");
            }
        }

        //print(distanceToPlayer + " - " + detected);

    }

    IEnumerator Ronda()
    {
        haciendoRonda = true;
        agent.speed = 0f;
        goal = transform.position;
        animator.SetBool("Walk", false);
        animator.SetBool("Run", false);
        animator.SetBool("Atack", false);
        while (!detected)
        {
            agent.speed = 0.4f;
            goal = SetRandomGoal(transform.position, 5f);
            yield return new WaitForSeconds(10f);

            agent.SetDestination(goal);

        }
    }


}