using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Componente ChContr
    CharacterController character;

    //Componente Animator
    Animator animator;

    //Iput
    InputActions inputActions;
    Vector2 movePlayer;
    float strafeL;
    float strafeR;
    bool corriendo;
    bool caminando;
    bool desplazando;

    //Velocidad de desplazamiento
    float speed; //Velocidad de desplazamiento
    Vector3 dir; //Dirección hacia la que se mueve
    float strafe; //Velocidad de desplazamiento lateral

    private void Awake()
    {
        inputActions = new InputActions();

        //Joystick Izq
        inputActions.Player.Moverse.performed += ctx => movePlayer = ctx.ReadValue<Vector2>();
        inputActions.Player.Moverse.canceled += ctx => movePlayer = Vector2.zero;

        //Desplaz Izq
        inputActions.Player.Despl_Izq.performed += ctx => strafeL = ctx.ReadValue<float>();
        inputActions.Player.Despl_Izq.canceled += ctx => strafeL = 0f;

        //Desplaz Dcho
        inputActions.Player.Despl_Dcha.performed += ctx => strafeR = ctx.ReadValue<float>();
        inputActions.Player.Despl_Dcha.canceled += ctx => strafeR = 0f;

        //Correr
        inputActions.Player.Correr.started += _ => StartRun();
        inputActions.Player.Correr.canceled += _ => StopRun();
    }

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        print(character.isGrounded);
        //print(movePlayer.y);

        Girar();

        if (corriendo && movePlayer.y > 0.5f)
        {
            character.SimpleMove(dir * speed);
        }
        else
        {
            Caminar();
        }

        Strafe();

    }

    void Strafe()
    {

        if (strafeL != 0 || strafeR != 0)
        {
            animator.SetBool("StrafeBool", true);
            float strafeValue = strafeR - strafeL;
            animator.SetFloat("Strafe", strafeValue);
            speed = 2.2f;
            dir = transform.TransformDirection(Vector3.right);
            character.SimpleMove(dir * strafeValue * speed);
        }
        else
        {
            speed = 2.5f;
            dir = transform.TransformDirection(Vector3.forward);
            animator.SetBool("StrafeBool", false);
        }
        /*
        speed = 1.2f;
        dir = transform.TransformDirection(Vector3.right);
        character.SimpleMove(dir * speed);
        */
    }

    void Girar()
    {
        transform.Rotate(0f, movePlayer.x * 0.6f, 0f);
    }

    void Caminar()
    {
        if (movePlayer.y < 0)
        {
            speed = 0.9f;
        }
        else
        {
            speed = 2.5f;
        }

        dir = transform.TransformDirection(Vector3.forward);
        character.SimpleMove(dir * speed * movePlayer.y);
        animator.SetFloat("Caminar", movePlayer.y);
    }




    void StartRun()
    {
        animator.SetBool("Run", true);
        speed = 5f;
        dir = transform.TransformDirection(Vector3.forward);
        corriendo = true;

    }

    void StopRun()
    {
        animator.SetBool("Run", false);
        speed = 2.5f;
        corriendo = false;
    }


    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}