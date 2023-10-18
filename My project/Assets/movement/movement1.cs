using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
   public float speed = 1f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S)){
            transform.position += new Vector3(0,0,speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0, 0 , -speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A)){
            transform.position += new Vector3(Time.deltaTime * speed,0,0);
        }

        if(Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(Time.deltaTime * -speed,0,0);
        }

       


    }
}