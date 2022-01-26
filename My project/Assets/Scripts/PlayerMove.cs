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
    //Estados
    bool corriendo;
    bool desplazando;

    //Velocidad de desplazamiento
    float speed; //Velocidad de desplazamiento
    Vector3 dir; //Dirección hacia la que se mueve
    float strafe; //Velocidad de desplazamiento lateral

    //Camaras
    [SerializeField] GameObject VCam, FreeCam;

    private void Awake()
    {
        inputActions = new InputActions();

        //Joystick Izq
        inputActions.Player.Moverse.performed += ctx => movePlayer = ctx.ReadValue<Vector2>();
        inputActions.Player.Moverse.canceled += ctx => movePlayer = Vector2.zero;

        //Desplaz Izq
        inputActions.Player.Despl_izq.performed += ctx => strafeL = ctx.ReadValue<float>();
        inputActions.Player.Despl_izq.canceled += ctx => strafeL = 0f;

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

        VCam = GameObject.Find("Vcam1");
        FreeCam = GameObject.Find("CM FreeLook1");

        VCam.SetActive(false);
        FreeCam.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

        if (strafeL != 0 || strafeR != 0)
        {
            desplazando = true;
        }
        else
        {
            desplazando = false;
        }

        //Estados
        if (corriendo && movePlayer.y > 0)
        {
            animator.SetBool("Correr", true);
            animator.SetBool("Lateral", false);
            speed = 5f;
            dir = transform.TransformDirection(Vector3.forward);
            character.SimpleMove(dir * speed);
        }
        else if (desplazando)
        {
            animator.SetBool("Correr", false);
            animator.SetBool("LateralBool", true);
            float strafeValue = strafeR - strafeL;
            animator.SetFloat("Lateral", strafeValue);
            speed = 2.2f;
            dir = transform.TransformDirection(Vector3.right);
            character.SimpleMove(dir * strafeValue * speed);
        }
        else
        {
            animator.SetBool("Correr", false);
            animator.SetBool("LateralBool", false);
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


        Girar();
    }

    void Apuntar()
    {
        VCam.SetActive(true);
        FreeCam.SetActive(false);
    }

    void Desapuntar()
    {
        VCam.SetActive(false);
        FreeCam.SetActive(true);
    }



    void Girar()
    {
        transform.Rotate(0f, movePlayer.x * 0.6f, 0f);
    }

    void StartRun()
    {

        corriendo = true;

    }

    void StopRun()
    {

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