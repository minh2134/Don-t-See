﻿using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Transform characterBody;
    public Rigidbody characterBodyrb;
    public Transform characterCamera;
    // Start is called before the first frame update
    // Update is called once per frame
    //Time.deltaTime help everythsing look the same on all system
    void FixedUpdate() {
        Vector3 f = characterCamera.forward;//foward direction of camera
        Vector3 r = characterCamera.right;//right direction of camera
        f.y = 0; //y position of camera will be 0
        r.y = 0;
        f = f.normalized;//normalize always
        r = r.normalized;


        characterBody.position += (f * Input.GetAxis("Vertical") + r * Input.GetAxis("Horizontal")) * Time.deltaTime * 5;
        //position of object moving in the direction of camera
    }
}
