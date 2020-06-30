using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Scripting;

public class UnlockDoor : MonoBehaviour
{
    public Image knightImage;
    public GameObject knightPiece;
    public GameObject lockedText;
    public GameObject unlockedText;
    public GameObject door;
    CapsuleCollider imageCollider;
    BoxCollider knightCollider;
    BoxCollider doorCollider;

    void Awake()
    {
        imageCollider = knightImage.GetComponent<CapsuleCollider>();
        knightCollider = knightPiece.GetComponent<BoxCollider>();
        doorCollider = door.GetComponent<BoxCollider>();
    }

    void FixedUpdate()
    {
        if (knightCollider.bounds.Intersects(imageCollider.bounds))
        {
            doorUnlock();
        }
    }

    void doorUnlock()
    {
        lockedText.SetActive(false);
        knightImage.enabled = false;
        unlockedText.SetActive(true);
        doorCollider.enabled = true;
    }



}
