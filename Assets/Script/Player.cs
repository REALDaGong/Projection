using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isControlActive = false;
    // Start is called before the first frame update
    [SerializeField]
    private Camera playerCamera;
    private Vector3 gravityDir;
    private Vector3 forwardDir;
    [SerializeField]
    private GameObject projectionPlane;
    [SerializeField]
    private float gravityStrength = 9.81f;
    private Rigidbody rb;
    private ConstantForce gravity;
    private ObjectManager objectManager;
    //状态
    private bool isJumping;
    private bool isOnGround;
    private bool isWalking;
    private bool isRunning;

    void Start()
    {
        if (projectionPlane != null)
        {
            gravityDir = projectionPlane.transform.rotation * new Vector3(1.0f, 0, 0);
            forwardDir = projectionPlane.transform.rotation * new Vector3(0, 0, 1.0f);
        }
        rb = GetComponent<Rigidbody>();
        gravity = GetComponent<ConstantForce>();
        gravity.force = gravityStrength * gravityDir;
        objectManager = ObjectManager.Instance;
        OnLevelStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnLevelStart()
    {
        PlayerInputHandler.Instance.TakeControl(this);
    }
    public void SetControlActive(bool isActive)
    {
        if (isActive != isControlActive)
        {
            PlayerInputHandler handler = PlayerInputHandler.Instance;
            isControlActive = isActive;
            if (isControlActive)
            {
                if (playerCamera)
                {
                    // If Camera.main object is disabled, Camera.main will get null
                    if (Camera.main)
                    {
                        Camera.main.gameObject.SetActive(false);
                    }

                    playerCamera.gameObject.SetActive(true);
                }
                else
                {
                    Camera.main.gameObject.SetActive(true);
                }

                handler.Axis1VerticalInputEvent += Jump;
                handler.Axis1HorizontalInputEvent += Move;
                handler.Axis2HorizontalInputEvent += RotateCameraH;
                handler.Axis2VerticalInputEvent += RotateCameraV;
                handler.CameraStopEvent += changeDir;
            }
            else
            {
                if (playerCamera)
                {
                    playerCamera.gameObject.SetActive(false);
                }

                handler.Axis1VerticalInputEvent -= Jump;
                handler.Axis1HorizontalInputEvent -= Move;
                handler.Axis2HorizontalInputEvent -= RotateCameraH;
                handler.Axis2VerticalInputEvent -= RotateCameraV;
                handler.CameraStopEvent -= changeDir;
            }
        }
    }

    private void changeDir()
    {
        if (projectionPlane != null)
        {
            gravityDir = projectionPlane.transform.right;
            gravity.force = gravityStrength * gravityDir;
            
            forwardDir = projectionPlane.transform.forward;
            objectManager.ReCalcObject();
        }
    }

    private void Move(float factor)
    {
        transform.Translate(Time.deltaTime * 1.0f * factor * forwardDir , Space.Self);
    }

    private void Jump(float factor)
    {
        if (IsOnGround())
        {
            rb.AddForce(factor * -gravityDir *3 , ForceMode.VelocityChange);
        }
    }

    private void RotateCameraH(float factor)
    {
        projectionPlane.transform.Rotate(Time.deltaTime * 1.0f * factor * new Vector3(0, 15.0f, 0), Space.Self);
    }

    private void RotateCameraV(float factor)
    {
        projectionPlane.transform.Rotate(Time.deltaTime * 1.0f * factor * new Vector3(0, 0, 15.0f), Space.Self);
    }
    private bool IsOnGround()
    {
        float distToGround = GetComponent<BoxCollider>().bounds.extents.y;
        return Physics.Raycast(transform.position, gravityDir, distToGround + 0.05f);
    }

}
