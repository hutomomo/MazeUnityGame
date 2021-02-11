using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

    GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
    GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
    [SerializeField]
    int stagesize = 50;

    // Start is called before the first frame update
    void Start()
    {

        GameObject obj = (GameObject)Resources.Load("WallCube");
        GameObject obj2 = (GameObject)Resources.Load("DeleteCube");
        GameObject obj3 = (GameObject)Resources.Load("PathCube");
        for (int i = 1; i < stagesize; i += 1)
        {
            for (int k = 1; k < 50; k += 1)
            {
                if (i * k  == 1)
                {
                    Instantiate(obj2, new Vector3(i * 1.0f, 1.0f, k * 1.0f), Quaternion.identity);
                }
                else if (i * k % 2 != 1)
                {
                    Instantiate(obj, new Vector3(i * 1.0f, 1.0f, k * 1.0f), Quaternion.identity);
                }
                else
                {
                    Instantiate(obj3, new Vector3(i * 1.0f, 1.0f, k * 1.0f), Quaternion.identity);
                }

            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }


}
