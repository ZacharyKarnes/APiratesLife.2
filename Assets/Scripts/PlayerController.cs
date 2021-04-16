﻿using System;
using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class PlayerController : MonoBehaviour

{

    //setup vars

    private InputHandler input;

    private CharacterController controller;

    private AnimatorHandler animatorHandler;

    
    public BattleStats battle;



    public Transform camParent;

    public Transform cam;



    //control stats

    public float speed = 8f;

    public float rotationSpeed = 10f;



    //gravity and jumping

    public bool grounded = true;

    public float gravity = -9.81f;

    public float jumpHeight = 2;

    private float groundDist = .2f;



    public Transform groundCheck;

    public LayerMask groundMask;



    private Vector3 velocity;

    

    


    void Start()

    {

        input = InputHandler.instance;

        controller = GetComponent<CharacterController>();

        animatorHandler = GetComponent<AnimatorHandler>();
    
        animatorHandler.Initialize();

    }



    void Update()

    {

        HandleMovement(Time.deltaTime);

        HandleRotation(Time.deltaTime);

        HandleGravity(Time.deltaTime);

        HandleJump();

        HandleAttack();
        HandleDodge();
        HandleDeath();



        animatorHandler.UpdateAnimatorValues(input.moveAmount, 0);

    }



    private void HandleMovement(float delta)

    {

        Vector3 movement = (input.move.x * camParent.right) + (input.move.y * camParent.forward);

        controller.Move(movement * speed * delta);

    }

    private void HandleRotation(float delta)

    {

        Vector3 targetDir;



        targetDir = cam.forward * input.move.y;



        targetDir += cam.right * input.move.x;



        targetDir.Normalize();



        targetDir.y = 0;



        if (targetDir == Vector3.zero)

        {

            targetDir = transform.forward;

        }



        Quaternion tr = Quaternion.LookRotation(targetDir);



        transform.rotation = Quaternion.Slerp(transform.rotation, tr, rotationSpeed * delta);

    }



    private void HandleGravity(float delta)

    {

        grounded = Physics.CheckSphere(groundCheck.position, groundDist, groundMask);



        if (grounded && velocity.y < 0)

        {

            velocity.y = -2f;

        }



        velocity.y += gravity * delta;

        controller.Move(velocity * delta);



    }



    private void HandleJump()
    {



        if (input.jumpDown && grounded)

        {

            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

            animatorHandler.UpdateJump(true);

        }

        else if (grounded)
        {

            animatorHandler.UpdateJump(false);

        }



    }





    private void HandleAttack()

    {
        
        if (input.rAttackOn)

        {
            animatorHandler.UpdateAttack(true);
            animatorHandler.UpdateRAttack(true);
            
          
        }
        else if (!input.rAttackOn) {
            animatorHandler.UpdateRAttack(false);
        }

        if (input.lAttackOn)
        {
           
            animatorHandler.UpdateLAttack(true);
            animatorHandler.UpdateAttack(true);

        }
        else if (!input.lAttackOn) {
            animatorHandler.UpdateLAttack(false);
        }




    }

    private void HandleDodge() {
        if (input.dodgeOn)
        {
            animatorHandler.UpdateDodge(true);
        }
        else if (!input.dodgeOn) {
            animatorHandler.UpdateDodge(false);
        }
    }

    private void HandleDeath() {
        if (!battle.isPlayerAlive) {
            animatorHandler.UpdateDeath(true);
        } else if (battle.isPlayerAlive) {
            animatorHandler.UpdateDeath(false);
        }
    }
}

