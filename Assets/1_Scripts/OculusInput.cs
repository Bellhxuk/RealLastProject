using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusInput : MonoBehaviour
{
    public OVRInput.Controller controllerType;
    public OVRInput.Button inputButton;

    public ParticleSystem ps;
    private bool isGrab;
    private void Start()
    {
        isGrab = false;
    }
    private void Update()
    {
        if (isGrab)
        {
            if (OVRInput.Get(inputButton, controllerType))
            {
                ps.Play();
            }
            else
            {
                ps.Stop();
            }
        }
    }

    public void ChangeGrabVal(bool b)
    {
        isGrab = b;
    }
}
