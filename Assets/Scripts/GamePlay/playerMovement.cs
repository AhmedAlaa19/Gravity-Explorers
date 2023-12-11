using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rB;
    public float forwardForce = 2000f;
    public float sidewayForce = 200f;
    public playerMovement Movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rB.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rB.AddForce(sidewayForce * Time.deltaTime, 0 ,0 ,ForceMode.VelocityChange); 
        }


        if (Input.GetKey("a"))
        {
            rB.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(transform.position.y <= 0)
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }



    }
}
