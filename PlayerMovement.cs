using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 15.0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate((Vector3.up)*moveSpeed *Time.deltaTime);
            Debug.Log("Presssing W Key");
        }

        if (Input.GetKey("a"))
        {
            transform.Translate((Vector3.left)*moveSpeed *Time.deltaTime);
            Debug.Log("Presssing A Key");
        }
        if (Input.GetKey("s"))
        {
            transform.Translate((Vector3.down) * moveSpeed * Time.deltaTime);
            Debug.Log("Presssing S Key");
        }
        if (Input.GetKey("d"))
        {
            transform.Translate((Vector3.right) * moveSpeed * Time.deltaTime); 
            Debug.Log("Presssing D Key");
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log(Input.GetAxis("Fire1"));
            Debug.Log("Presssing Fire1 Key");
        }
        if(Input.GetMouseButton(1)) //right mouse button
        {
            moveSpeed = 25.0f;
            Debug.Log("Right Mouse Button");
        }
        if (!Input.GetMouseButton(1)) //right mouse button
        {
            moveSpeed = 15.0f;
            Debug.Log("Right Mouse Button");
        }
        if (Input.GetMouseButton(0)) //left mouse button
        {
            Debug.Log("Left Mouse Button");
        }
    }
}
