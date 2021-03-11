using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float sideMovement = 200;
    public float forwardMovement = 1000;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      rb.AddForce(0, 0, forwardMovement * Time.deltaTime);

      if (Input.GetKey("d"))
      {
        rb.AddForce(sideMovement * Time.deltaTime, 0, 0);
      }

      if (Input.GetKey("a"))
      {
        rb.AddForce(-sideMovement * Time.deltaTime, 0, 0);
      }
    }
}
