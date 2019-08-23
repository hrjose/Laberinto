using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laberinto : MonoBehaviour
{
    public float velocidad;

    void start(){
       
    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxis("Horizontal")*-1*velocidad*Time.deltaTime;
        float x = Input.GetAxis("Vertical")*velocidad*Time.deltaTime;

        transform.Rotate(new Vector3(x,0,z));
    }
}
