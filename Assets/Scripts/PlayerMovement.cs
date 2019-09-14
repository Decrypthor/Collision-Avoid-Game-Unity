using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewaysforce = 125f;
    public Transform player;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce* Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
             
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
             
        }
        player.position = new Vector3(Mathf.Clamp(player.position.x, -6.6f, 6.6f), player.position.y, player.position.z);
        
    }
}
