using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_Death : MonoBehaviour
{
    public Transform TP;
    public GameObject ob;
    public bool dd = false;
    public static int score { get; private set; } = 0;
    void OnTriggerEnter (Collider other)
    {
        other.transform.position = TP.transform.position;
        dd = true;
        other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

    }
    private void FixedUpdate()
    {
        if (dd == true)
        {
            score++;
            dd = false;
        }
    }
    
}
