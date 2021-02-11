using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    
    private int number;
    public LayerMask mask;
    void Start()
    {

        RaycastHit hit;
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject obj = (GameObject)Resources.Load("Cube2");
        number = Random.Range(0, 3);
        if (this.transform.position.x < 3)
        {

            number = Random.Range(0, 4);
        }
        switch (number)
        {

            case 0:
                if (Physics.Raycast(transform.position, transform.forward, out hit, 1.0f))
                {
                    hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                    goto case 1;
                }
                Instantiate(obj, transform.position + transform.forward, Quaternion.identity);
                break;
            case 1:
                if (Physics.Raycast(transform.position, transform.right, out hit, 1.0f))
                {
                    goto case 2;
                }
                Instantiate(obj, transform.position + transform.right, Quaternion.identity);
                break;
            case 2:
                if (Physics.Raycast(transform.position, -transform.forward, out hit, 1.0f))
                {
                    goto case 0;
                }
                Instantiate(obj, transform.position - transform.forward, Quaternion.identity);
                break;
            case 3:
                if (Physics.Raycast(transform.position, -transform.right, out hit, 1.0f))
                {
                    hit.collider.GetComponent<MeshRenderer>().material.color = Color.blue;
                    goto case 0;
                }
                Instantiate(obj, transform.position - transform.right, Quaternion.identity);
                break;


        }


    }
    void Update()
    {

    }
}
