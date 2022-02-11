using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generaescena : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pieza;
    private GameObject[,] mapa;
    void Start()
    {
        int x = 200;
        int z = 200;
        mapa = new GameObject[x, z];
        float semilla = Random.Range(0.0f, 100.0f);
        float escala = 50.0f;
        int alturamax = 50;
        for (int i=0;i<x;i++)
        {
            for (int j = 0; j < z; j++)
            {
                float coorX = semilla + i / escala;
                float coory = semilla + j / escala;
                int y = (int)(Mathf.PerlinNoise(coorX, coory)*alturamax);
                mapa[i,j]=Instantiate(pieza, new Vector3(i, y, j), Quaternion.identity);
                if (y >= 40)
                {
                    mapa[i, j].GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
                }
                else
                {
                    mapa[i, j].GetComponent<Renderer>().material.color = new Color32(220, 113, 0, 255);
                }
            }
        }
        
    }

}
