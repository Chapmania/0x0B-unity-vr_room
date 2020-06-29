using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionCanvas : MonoBehaviour
{
    public GameObject InstructionsPanel;

    void FixedUpdate()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            ToggleInstructions();
        }
    }
    void ToggleInstructions()
    {
        if (InstructionsPanel.activeSelf)
        {
            InstructionsPanel.SetActive(false);
        }
        else
        {
            InstructionsPanel.SetActive(true);
        }
    }
}
