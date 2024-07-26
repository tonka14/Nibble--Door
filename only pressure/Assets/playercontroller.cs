using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playercontroller : MonoBehaviour
{
    private CharacterController chara;
    float Speed = 10f;
    void Start()
    {
        chara = GetComponent<CharacterController>();
    }


    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));

        chara.Move(move*Time.deltaTime*Speed);
    }

}
