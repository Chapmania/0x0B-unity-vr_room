using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class UnlockDoor : MonoBehaviour
{
    bool playSound = true;
    public Image knightImage;
    public GameObject knightPiece;
    public GameObject lockedText;
    public GameObject unlockedText;
    public GameObject door;
    public AudioSource unlockSound;
    CapsuleCollider imageCollider;
    BoxCollider knightCollider;
    BoxCollider doorCollider;
    AudioSource unlockSoundAudioSource;

    void Awake()
    {
        imageCollider = knightImage.GetComponent<CapsuleCollider>();
        knightCollider = knightPiece.GetComponent<BoxCollider>();
        doorCollider = door.GetComponent<BoxCollider>();
        unlockSoundAudioSource = unlockSound.GetComponent<AudioSource>();
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
        if (playSound)
        {
            unlockSoundAudioSource.Play();
            playSound = false;
        }
        lockedText.SetActive(false);
        knightImage.enabled = false;
        unlockedText.SetActive(true);
        doorCollider.enabled = true;
    }



}
