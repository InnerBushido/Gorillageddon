using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class RagdollGrab : XRGrabInteractable
{
    // public PuppetMaster puppetMaster;
    private ConfigurableJoint joint;
    private Rigidbody connectedBodyRB;

    /*
    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        Debug.Log("OnSelectEntering in RagdollGrab");
        base.OnSelectEntering(args);
        // joint = gameObject.AddComponent<ConfigurableJoint>();
        joint = gameObject.GetComponent<ConfigurableJoint>();
        connectedBodyRB = joint.connectedBody;
        joint.connectedBody = args.interactorObject.transform.GetComponent<Rigidbody>();
        joint.xMotion = ConfigurableJointMotion.Locked;
        joint.yMotion = ConfigurableJointMotion.Locked;
        joint.zMotion = ConfigurableJointMotion.Locked;
        // puppetMaster.SetMuscleWeights(0f); // Reduce muscle strength for limp grab
    }

    protected override void OnSelectExiting(SelectExitEventArgs args)
    {
        Debug.Log("OnSelectExiting in RagdollGrab");
        base.OnSelectExiting(args);
        joint.connectedBody = connectedBodyRB;
        // Destroy(joint);
        // puppetMaster.SetMuscleWeights(1f); // Restore muscle strength
    }
    */
}
