using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public Transform TeP;
    public GameObject ob;
    public bool dd = false;
    public static int wins { get; private set; } = 1;
    void OnTriggerEnter(Collider other1)
    {
        other1.transform.position = TeP.transform.position;
        dd = true;
        other1.GetComponent<Rigidbody>().velocity = Vector3.zero;
        other1.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

    }
    private void FixedUpdate()
    {
        if (dd == true)
        {
            wins++;
            dd = false;
        }
    }

}