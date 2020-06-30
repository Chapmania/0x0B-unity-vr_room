using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Collider Rcontroller;
    public Collider Lcontroller;
    Animator anim;
    Collider door;
    void Awake()
    {
        anim = GetComponent<Animator>();
        door = GetComponent<BoxCollider>();
    }

    void FixedUpdate()
    {
        if (Rcontroller.bounds.Intersects(door.bounds) && OVRInput.GetDown(OVRInput.Button.One))
        {
            if (anim.GetBool("open_door") == false)
                Open();
            else if (anim.GetBool("open_door") == true)
                Close();
        }
        if (Lcontroller.bounds.Intersects(door.bounds) && OVRInput.GetDown(OVRInput.Button.Three))
        {
            if (anim.GetBool("open_door") == false)
                Open();
            else if (anim.GetBool("open_door") == true)
                Close();            
        }

    }
    void Open()
    {
        anim.SetBool("open_door", true);
    }
    void Close()
    {
        anim.SetBool("open_door", false);
    }
}
