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
    MeshRenderer buttonMesh;
    SphereCollider buttonSphere;
    Light buttonLight;
    Light lightShadow;
    Transform lightPos;
    // Animation anim;


    void Awake()
    {
        // Animation = GetComponent<Animation>();
        // buttonMesh.material = originalButton;
        buttonMesh = button.GetComponent<MeshRenderer>();
        buttonSphere = button.GetComponent<SphereCollider>();
        buttonLight = button.GetComponent<Light>();
        lightShadow = directionalLight.GetComponent<Light>();
        lightPos = directionalLight.GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        if (RController.bounds.Intersects(buttonSphere.bounds) && OVRInput.GetDown(OVRInput.Button.One))
        {
            buttonMesh.material = redButton;
            buttonLight.color = Color.red;
            particles.SetActive(true);
            // RenderSettings.skybox.color = Color.black;
            // changeLight.
        }
        if (LController.bounds.Intersects(buttonSphere.bounds) && OVRInput.GetDown(OVRInput.Button.Three))
        {
            buttonMesh.material = redButton;
            buttonLight.color = Color.red;
            particles.SetActive(true);
        }
    }
}
