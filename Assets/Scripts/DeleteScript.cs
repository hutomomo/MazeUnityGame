using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScript : MonoBehaviour
{
    private int number;
    public LayerMask mask;
    RaycastHit hit;
    void Start()
    {
        
        number = Random.Range(0, 4);
        switch (number)
        {

            case 0:
                if (Physics.Raycast(transform.position, transform.forward, out hit, 2.0f))
                {
                    hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                    break;
                }
                goto case 1;
            case 1:
                if (Physics.Raycast(transform.position, transform.right, out hit, 1.0f))
                {
                    hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;

                    break;
                }
                goto case 2;
            case 2:
                if (Physics.Raycast(transform.position, -transform.forward, out hit, 1.0f))
                {
                    hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                    break;
                }
                goto case 3;
            case 3:
                if (Physics.Raycast(transform.position, -transform.right, out hit, 1.0f))
                {
                    hit.collider.GetComponent<MeshRenderer>().material.color = Color.blue;
                    break;
                }                
                goto case 0;

        }


    }
    void Update()
    {

    }
}