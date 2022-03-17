using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController3 : MonoBehaviour
{

    public GameObject r1, r2, r3, r4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (r3.GetComponent<Resistores3>().modificado == true && r4.GetComponent<Resistores3>().modificado == true)
        {
            do
            {
                r3.transform.position = new Vector3(r3.transform.position.x + 0.2f, r3.transform.position.y - 0.2f, 1f);
            } while (r3.transform.position.x != r4.transform.position.x);
        }
    }
}
