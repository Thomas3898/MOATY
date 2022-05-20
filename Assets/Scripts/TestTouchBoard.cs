using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTouchBoard : MonoBehaviour
{
    float speed = 2f;

    void Start(){
        Debug.Log ("Ready");
    }

    void Update(){
        if (Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.right * speed);
        }   

        if (Input.GetKey(KeyCode.T)){
            transform.Translate(Vector3.right * -speed);
        } 

        if (Input.GetKey(KeyCode.E)){
            transform.Translate(Vector3.up * speed);
        }   

        if (Input.GetKey(KeyCode.U)){
            transform.Translate(Vector3.up * -speed);
        }   
    }  
}


