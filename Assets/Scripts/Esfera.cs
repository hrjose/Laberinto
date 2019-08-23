using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Esfera : MonoBehaviour
{
    Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        RB.AddForce(0, -0.001f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            Debug.Log("llegaste a la meta");
        }
    }

   
}
