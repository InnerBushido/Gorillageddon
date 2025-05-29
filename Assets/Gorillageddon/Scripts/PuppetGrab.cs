using System;
using RootMotion.Dynamics;
using UnityEngine;

public class PuppetGrab : MonoBehaviour
{
    
    private PuppetMaster puppetMaster;

    private void Start()
    {
        puppetMaster = GetComponent<PuppetMaster>(); // gets the PuppetMaster Component
    }
    
    public void LowerPin(float minPinweight = 0f)//set max, 1 min 0, lowers puppet master pin value on grab
    {
        puppetMaster.pinWeight = minPinweight;
        // StartCoroutine(ReleaseGrab()); //  starts drop coroutine so you can hold the guy in the air till he dies
    }

    public void RaisePin(float maxPinWeight = 1f) // set max, min 0, raises puppet master pin value on release
    {
        puppetMaster.pinWeight = maxPinWeight;
    }
}
