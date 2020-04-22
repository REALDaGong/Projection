using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    public static PlayerInputHandler Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PlayerInputHandler>();
                if (instance == null)
                {
                    instance = new GameObject("PlayerInputHandler").AddComponent<PlayerInputHandler>();
                }
            }
            return instance;
        }
    }

    private static PlayerInputHandler instance;

    public event Action<float> Axis1HorizontalInputEvent;
    public event Action<float> Axis1VerticalInputEvent;
    public event Action<float> Axis2HorizontalInputEvent;
    public event Action<float> Axis2VerticalInputEvent;
    public event Action FireInputEvent;
    public event Action CameraStopEvent;

    public event Action<bool> SetControlActiveEvent;

    public void TakeControl(Player player)
    {
        if (SetControlActiveEvent != null)
        {
            SetControlActiveEvent(false);
        }
        player.SetControlActive(true);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Axis1HorizontalInputEvent?.Invoke(-3.0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Axis1HorizontalInputEvent?.Invoke(3.0f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Axis1VerticalInputEvent?.Invoke(1.0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //Axis1VerticalInputEvent?.Invoke(-1.0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Axis2HorizontalInputEvent?.Invoke(-1.0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Axis2HorizontalInputEvent?.Invoke(1.0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Axis2VerticalInputEvent?.Invoke(1.0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Axis2VerticalInputEvent?.Invoke(-1.0f);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FireInputEvent?.Invoke();
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            CameraStopEvent?.Invoke();
        }
    }
}
