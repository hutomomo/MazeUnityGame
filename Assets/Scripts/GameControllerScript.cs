using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    [SerializeField]
    int stagesize = 50;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = (GameObject)Resources.Load("Cube");
        for (int i = 2; i < stagesize;i += 2)
        {
            for (int k = 2; k < 50; k += 2)
            {

                Instantiate(obj, new Vector3(i * 1.0f, 1.0f, k * 1.0f), Quaternion.identity);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
