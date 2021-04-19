using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class CameraController : MonoBehaviour

{

    //follow stuff

    public Transform targetTransform; //where the player is

    public Transform pivotTransform;

    public Transform camTransform;



    private Vector3 cameraFollowVelocity = Vector3.zero;



    public float followSpeed = .1f;



    //rotation stuff

    private InputHandler input;



    private float lookAngle;

    private float pivotAngle;



    public float lookSpeed = .03f;

    public float pivotSpeed = .03f;



    public float minPivot = -35;

    public float maxPivot = 35;



    //collision stuff

    public float targetPos;

    private float defaultPos;



    public LayerMask ignoreLayers;



    private Vector3 camPos; //used only for z position



    public float cameraSphereRadius = .2f;

    public float cameraCollisionOffset = .2f;

    public float minCollisionOffset = .2f;



    private void Awake()

    {

        defaultPos = camTransform.localPosition.z;

    }



    void Start()

    {

        input = InputHandler.instance;

    }





    void Update()

    {

        FollowTarget(Time.deltaTime);

        HandleRotation(Time.deltaTime);

        HandleCollisions(Time.deltaTime);

    }



    /// <summary>

    /// Moves the transform of the camera holder/parent towards the player

    /// </summary>

    /// <param name="delta"></param>

    private void FollowTarget(float delta)

    {

        //create a Vector3 for a position somewhere between the cameraHolder and the player

        Vector3 goal =

            Vector3.SmoothDamp(transform.position, targetTransform.position, ref cameraFollowVelocity, delta / followSpeed);



        //assign the value of that vector3 to the cameraHolder transform position

        transform.position = goal;

    }



    private void HandleRotation(float delta)

    {

        float mouseX = input.look.x;

        float mouseY = input.look.y;



        lookAngle += (mouseX * lookSpeed) / delta;

        pivotAngle -= (mouseY * pivotSpeed) / delta;



        pivotAngle = Mathf.Clamp(pivotAngle, minPivot, maxPivot);



        //THE FOLLOWING SECTION APPLIES SIDE TO SIDE ROTATION:



        //create a vector3 to store the look rotation in

        Vector3 rotation = Vector3.zero;



        //assign the lookAngle to the y axis of the vector

        rotation.y = lookAngle;



        //create a Quaternion using the vector

        Quaternion targetRot = Quaternion.Euler(rotation);



        //assign the Quaternion to the camera holder/parent

        transform.rotation = targetRot;



        //THE FOLLOWING SECTION APPLIES UP AND DOWN ROTATION:



        //zero out the vector3

        rotation = Vector3.zero;



        //assign the pivotAngle to the x axis of the vector

        rotation.x = pivotAngle;



        //assign the Quaternion to the vector3

        targetRot = Quaternion.Euler(rotation);



        //assign the Quaternion to the local rotation of the camera pivot

        pivotTransform.localRotation = targetRot;

    }



    private void HandleCollisions(float delta)

    {

        targetPos = defaultPos;



        RaycastHit hit;



        Vector3 direction = camTransform.position - pivotTransform.position;

        direction.Normalize();



        if (Physics.SphereCast(pivotTransform.position, cameraSphereRadius, direction, out hit, Mathf.Abs(targetPos), ignoreLayers))
        {



            float dis = Vector3.Distance(pivotTransform.position, hit.point);



            targetPos = -(dis - cameraCollisionOffset);



            if (Mathf.Abs(targetPos) < minCollisionOffset)

            {

                targetPos = -minCollisionOffset;

            }



        }



        camPos.z = Mathf.Lerp(camTransform.localPosition.z, targetPos, delta / .2f);



        camTransform.localPosition = camPos;

    }

}