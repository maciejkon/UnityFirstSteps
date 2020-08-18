using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forwardForce = 2000;
    public float sidewaysForce = 100;

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(-forwardForce*Time.deltaTime, 0, 0);

        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(0, 0, sidewaysForce * Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            //VelocityChange ignoruje masę 
            rigidbody.AddForce(0, 0, -sidewaysForce * Time.deltaTime,ForceMode.VelocityChange);
        }
        if (rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        


    }
}
