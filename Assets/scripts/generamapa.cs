using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generamapa : MonoBehaviour
{
    public GameObject pieza;
    public int x;
    public int z;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0;i<x;i++)
        {
            for (int j=0;j<z;j++)
            {
                if (Mathf.PerlinNoise(Random.Range(0f,100f),Random.Range(0f,100f))<0.5f)
                {
                    Instantiate(pieza, new Vector3(i * 5, 0, j * 5), Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
