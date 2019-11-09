using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed;
    private CharacterController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent< CharacterController > ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && playerController.isGrounded)
        {
            playerController.Move(Vector3.up);
        }
    }
}
