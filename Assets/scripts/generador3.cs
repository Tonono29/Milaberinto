using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador3 : MonoBehaviour
{
    public GameObject pieza;
    public int totalpiezas;
    private GameObject piezactual;
    private bool hayhueco;
    // Start is called before the first frame update
    void Start()
    {
        hayhueco = true;
        piezactual = null;
        StartCoroutine(generapieza(0,0));
    }
    IEnumerator generapieza(float x, float z)
    {
        yield return new WaitForEndOfFrame();
        if (totalpiezas>0)
        {
            if (hayhueco)
            {
                piezactual = Instantiate(pieza, new Vector3(x, 0, z), Quaternion.identity);
                totalpiezas--;
            }
            float newx=0;
            float newz=0;
            int sentidocreci = Random.Range(0, 4);
            RaycastHit hit;
            switch(sentidocreci)
            {
                case 0://Norte
                   if (Physics.Raycast(piezactual.transform.position,transform.forward,out hit,3))
                    {
                        hayhueco = false;
                        piezactual = hit.transform.gameObject;
                    }
                   else
                    {
                        hayhueco = true;
                    }
                   newx = piezactual.transform.position.x;
                   newz = piezactual.transform.position.z + 5;
                  break;
                case 1://sur
                    if (Physics.Raycast(piezactual.transform.position, transform.forward*-1, out hit, 3))
                    {
                        hayhueco = false;
                        piezactual = hit.transform.gameObject;
                    }
                    else
                    {
                        hayhueco = true;
                    }
                    newx = piezactual.transform.position.x;
                    newz = piezactual.transform.position.z - 5;
                    break;
                case 2://este
                    if (Physics.Raycast(piezactual.transform.position, transform.right, out hit, 3))
                    {
                        hayhueco = false;
                        piezactual = hit.transform.gameObject;
                    }
                    else
                    {
                        hayhueco = true;
                    }
                    newx = piezactual.transform.position.x+5;
                    newz = piezactual.transform.position.z;
                    break;
                case 3://oeste
                    if (Physics.Raycast(piezactual.transform.position, transform.right*-1, out hit, 3))
                    {
                        hayhueco = false;
                        piezactual = hit.transform.gameObject;
                    }
                    else
                    {
                        hayhueco = true;
                    }
                    newx = piezactual.transform.position.x-5;
                    newz = piezactual.transform.position.z;
                    break;
            }
            StartCoroutine(generapieza(newx, newz));
        }
    }

    // Update is called once per frame
}
