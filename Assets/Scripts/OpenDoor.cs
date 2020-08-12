using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script allows the user to open the door once the console has been unlocked.
/// </summary>  
public class OpenDoor : MonoBehaviour
{
    /// <summary>
    /// The Right Controller.
    /// </summary>  
    public Collider Rcontroller;

    /// <summary>
    /// The Left Controller.
    /// </summary> 
    public Collider Lcontroller;

    /// <summary>
    /// Animator for the door swinging open.
    /// </summary> 
    Animator anim;

    /// <summary>
    /// The door GameObject.
    /// </summary> 
    Collider door;

    /// <summary>
    /// Instantiates the variables.
    /// </summary> 
    void Awake()
    {
        anim = GetComponent<Animator>();
        door = GetComponent<BoxCollider>();
    }

    /// <summary>
    /// Constantly checks to see if either the bounds of the Right or Left controller intersect with
    /// the bounds of the door. If they do and the user presses the correct button, the door will
    /// swing open (if it has been unlocked with the console).
    /// </summary> 
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

    /// <summary>
    /// Method to have the door animate open.
    /// </summary> 
    void Open()
    {
        anim.SetBool("open_door", true);
    }

    /// <summary>
    /// Method to have the door animate closed.
    /// </summary> 
    void Close()
    {
        anim.SetBool("open_door", false);
    }
}
