using System;
using UnityEngine;

public class ControllerOffsetHeightFix : MonoBehaviour
{
    public Transform controllerToFollow;
    
    private void LateUpdate()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, -(controllerToFollow.localPosition.y * 0.5f) * transform.localScale.y, transform.localPosition.z);
    }
}
