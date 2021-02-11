using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScript : MonoBehaviour
{
 /*   private int number;
    int layerMask = 1 << 9 ;
    int WallMask = 1 << 8 ;
    
    RaycastHit hit;
    RaycastHit hit2;*/
    void Start()
    {
        /*Ray forwardray = new Ray(transform.position, transform.forward);
        Ray rightray = new Ray(transform.position, transform.right);
        Ray backray = new Ray(transform.position, -transform.forward);
        Ray leftray = new Ray(transform.position, transform.right);
        Debug.Log(this.transform.position.x + this.transform.position.z);
        InvokeRepeating("Call", 1, 1);
        if ((this.transform.position.x + this.transform.position.z) % 4 == 0)
        {

            CancelInvoke("Call");
            //Invoke("Goal", 4f);
        }
        else
        {
            Invoke("Call", 2f);
        }*/

    }

 /*   void Call()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2.0f, layerMask) || Physics.Raycast(transform.position, -transform.forward, out hit, 2.0f, layerMask) || Physics.Raycast(transform.position, transform.right, out hit, 2.0f, layerMask) || Physics.Raycast(transform.position, -transform.right, out hit, 2.0f, layerMask))
        {

            number = Random.Range(0, 4);
            switch (number)
            {

                case 0:
                    if (Physics.Raycast(transform.position, transform.forward, out hit, 2.0f, layerMask))
                    {

                        Destroy(hit.collider.gameObject);
                        Physics.Raycast(transform.position, transform.forward, out hit2, 1.0f, WallMask);
                        hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                        Destroy(hit2.collider.gameObject);
                        this.transform.position += transform.forward * 2;
                        break;
                    }
                    goto case 1;
                case 1:
                    if (Physics.Raycast(transform.position, transform.right, out hit, 2.0f, layerMask))
                    {
                        Destroy(hit.collider.gameObject);
                        Physics.Raycast(transform.position, transform.right, out hit2, 1.0f, WallMask);
                        hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                        Destroy(hit2.collider.gameObject);
                        //Destroy(this.gameObject);
                        this.transform.position += transform.right * 2;
                        break;
                    }
                    goto case 2;
                case 2:
                    if (Physics.Raycast(transform.position, -transform.forward, out hit, 2.0f, layerMask))
                    {
                        Destroy(hit.collider.gameObject);
                        hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                        Physics.Raycast(transform.position, -transform.forward, out hit2, 1.0f, WallMask);
                        Destroy(hit2.collider.gameObject);
                        //Destroy(this.gameObject);
                        this.transform.position -= transform.forward * 2;
                        break;
                    }
                    goto case 3;
                case 3:
                    if (Physics.Raycast(transform.position, -transform.right, out hit, 2.0f, layerMask))
                    {
                        Destroy(hit.collider.gameObject);
                        Physics.Raycast(transform.position, -transform.right, out hit2, 1.0f, WallMask);
                        hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                        Destroy(hit2.collider.gameObject);

                        //Destroy(this.gameObject);
                        this.transform.position -= transform.right * 2;
                        break;
                    }
                    goto case 0;

            }
        }
        else
        {
            Physics.Raycast(transform.position, -transform.right, out hit2, 1.0f, WallMask);
            //Destroy(this.gameObject);
            break;
        }
        Debug.Log(this.transform.position);
        Debug.Log(hit);
    }*/
/*    void Goal()
    {
        number = Random.Range(0, 4);
        switch (number)
        {

            case 0:
                if (Physics.Raycast(transform.position, transform.forward, out hit, 1.0f))
                {
                    Destroy(hit.collider.gameObject);
                    Destroy(this.gameObject);
                    break;
                }
                goto case 1;
            case 1:
                if (Physics.Raycast(transform.position, transform.right, out hit, 1.0f))
                {
                    Destroy(hit.collider.gameObject);
                    Destroy(this.gameObject);
                    break;
                }
                goto case 2;
            case 2:
                if (Physics.Raycast(transform.position, -transform.forward, out hit, 1.0f))
                {
                    Destroy(hit.collider.gameObject);
                    Destroy(this.gameObject);
                    break;
                }
                goto case 3;
            case 3:
                if (Physics.Raycast(transform.position, -transform.right, out hit, 1.0f))
                {
                    Destroy(hit.collider.gameObject);
                    Destroy(this.gameObject);
                    break;
                }
                goto case 0;

        }
    }*/
        


    
    void Update()
    {

    }
}