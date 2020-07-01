using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPush : MonoBehaviour
{
    public Collider RController;
    public Collider LController;
    public GameObject button;
    public Material originalButton;
    public Material redButton;
    public GameObject particles;
    public GameObject directionalLight;
    public AudioSource buttonPress;
    bool playSound = true;
    MeshRenderer buttonMesh;
    SphereCollider buttonSphere;
    Light buttonLight;
    Light lightShadow;
    Transform lightPos;
    AudioSource playButtonPress;

    void Awake()
    {
        buttonMesh = button.GetComponent<MeshRenderer>();
        buttonSphere = button.GetComponent<SphereCollider>();
        buttonLight = button.GetComponent<Light>();
        lightShadow = directionalLight.GetComponent<Light>();
        lightPos = directionalLight.GetComponent<Transform>();
        playButtonPress = buttonPress.GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        if (RController.bounds.Intersects(buttonSphere.bounds) && OVRInput.GetDown(OVRInput.Button.One))
        {
            pushButton();
        }
        if (LController.bounds.Intersects(buttonSphere.bounds) && OVRInput.GetDown(OVRInput.Button.Three))
        {
            pushButton();
        }
    }

    void pushButton()
    {
        if (playSound)
        {
            playButtonPress.Play();
            playSound = false;
        }
        buttonMesh.material = redButton;
        buttonLight.color = Color.red;
        particles.SetActive(true);
    }
}
