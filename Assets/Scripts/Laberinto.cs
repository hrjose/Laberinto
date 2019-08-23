using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Laberinto : MonoBehaviour
{
    [SerializeField] GameObject caja1;
    [SerializeField] GameObject laberinto;
    [Range(0,120f)]
    [SerializeField] float velocidad;
    // Update is called once per frame
    void Update()
    {
        float x= Input.GetAxis("Vertical")*velocidad*Time.deltaTime;
        float z= Input.GetAxis("Horizontal")*-1*velocidad*Time.deltaTime;

        caja1.transform.Rotate(new Vector3(x,0,0));
        laberinto.transform.Rotate(new Vector3(0,0,z));

    }
}

    
