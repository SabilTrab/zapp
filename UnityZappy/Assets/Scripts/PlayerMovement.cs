using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
    }


}