using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class InputHandler : MonoBehaviour

{

    public static InputHandler instance;



    private PlayerControls controls;



    public Vector2 move;

    public Vector2 look;





    public bool jumpDown = false;

    public bool sprintOn = false;

    public bool rAttackOn = false;

    public bool lAttackOn = false;


    public float moveAmount { get; private set; }



    private void Awake()

    {

        if (instance != null)

        {

            Destroy(this);

        }

        else

        {

            instance = this;

        }



        controls = new PlayerControls();

    }



    private void OnEnable()

    {

        controls.Enable();

    }



    private void OnDisable()

    {

        controls.Disable();

    }



    void Start()

    {

        controls.Locomotion.Move.performed += controls =>

        {

            move = controls.ReadValue<Vector2>();

            moveAmount = Mathf.Clamp01(Mathf.Abs(move.x) + Mathf.Abs(move.y));

        };



        controls.Locomotion.Look.performed += controls => look = controls.ReadValue<Vector2>();



        //Jump

        controls.Locomotion.Jump.performed += controls => jumpDown = true;

        controls.Locomotion.Jump.canceled += controls => jumpDown = false;



        //sprint

        controls.Locomotion.Sprint.performed += controls => sprintOn = true;

        controls.Locomotion.Sprint.canceled += controls => sprintOn = false;



        //attack

        controls.Locomotion.RAttack.performed += controls =>  rAttackOn = true;
     
 

        controls.Locomotion.RAttack.canceled += controls => rAttackOn = false;

        controls.Locomotion.LAttack.performed += controls => lAttackOn = true;

        controls.Locomotion.LAttack.canceled += controls => lAttackOn = false;





    }

}