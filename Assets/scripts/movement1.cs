using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement1 : MonoBehaviour
{
    public CharacterController2D characterController;
    public float runspeed=40f;
    float horizontalmove = 0f;
    bool jump = false;
    void Update()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal") * runspeed;
        
    }
    private void FixedUpdate()
    {
        characterController.Move(horizontalmove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
