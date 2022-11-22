using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float turnSpeed = 20f;
    public float horizontalMove = 0f;
    public float runSpeed = 40f;
    public float sensitivity = 40f;

    public GameObject player;

    public Joystick joystick;

    Animator m_Animator;
    Rigidbody m_Rigidbody;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;

    void Start ()
    {
       
    }

    void FixedUpdate ()
    {
        
        float horizontal = -joystick.Horizontal/sensitivity;
        float vertical = -joystick.Vertical/sensitivity;
        
        m_Movement.Set(horizontal, 0f, vertical);
        m_Movement.Normalize ();
        player.transform.Translate(m_Movement*Time.deltaTime);
        

    }
}
