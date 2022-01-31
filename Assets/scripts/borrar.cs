using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borrar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Quitarparedes", 5);
        
    }

    // Update is called once per frame
    public void Quitarparedes()
    {
        GameObject norte = transform.GetChild(1).gameObject;
        GameObject sur = transform.GetChild(2).gameObject;
        GameObject este = transform.GetChild(3).gameObject;
        GameObject oeste = transform.GetChild(0).gameObject;
        if (Physics.Raycast(transform.position,transform.forward,6))
        {
            Destroy(sur);
        }
        if (Physics.Raycast(transform.position, transform.forward*-1, 6))
        {
            Destroy(norte);
        }
        if (Physics.Raycast(transform.position, transform.right, 6))
        {
            Destroy(este);
        }
        if (Physics.Raycast(transform.position, transform.right*-1, 6))
        {
            Destroy(oeste);
        }
    }
}
