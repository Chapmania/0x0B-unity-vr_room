using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPulse : MonoBehaviour
{
    Light buttonLight;

    void Awake()
    {
        buttonLight = GetComponent<Light>();
    }
    void FixedUpdate()
    {
        buttonLight.intensity = Mathf.PingPong(Time.deltaTime, 6);
    }
}
