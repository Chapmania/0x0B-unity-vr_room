using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{
    public GameObject collidingObject;
    public GameObject objectInHand;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<GameObject>())
                collidingObject = other.gameObject;
    }
    public void OnTriggerExit(Collider other)
    {
        collidingObject = null;
    }
}
