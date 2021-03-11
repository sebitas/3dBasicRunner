using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sideForce = 2000;
    public float forwardForce = 100;
    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("aaa");
    }

    // Update is called once per frame
    void Update()
    {
      rb.AddForce(0,0,forwardForce * Time.deltaTime);

      if (Input.GetKey("d"))
      {
        rb.AddForce(sideForce * Time.deltaTime,0,0);
      }

      if (Input.GetKey("a"))
      {
        rb.AddForce(-sideForce * Time.deltaTime,0,0);
      }
    }
}
