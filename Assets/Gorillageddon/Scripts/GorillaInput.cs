using System;
using GorillaLocomotion;
using UnityEngine;
using UnityEngine.InputSystem;

public class GorillaInput : MonoBehaviour
{
    [SerializeField] private InputActionReference locomotionToggleInput;
    [SerializeField] private Player playerLocomotion;
    [SerializeField] private Transform playerCapsuleGrower;
    [SerializeField] private CapsuleCollider playerCapsuleCollider;

    [SerializeField] private float capsuleGrowerScale = 2;
    
    private float originalPlayerCapsuleScale;

    public float originalColliderCenter = -0.9641337f; // -0.3520669
    public float originalColliderHeight = 2.408267f;
    
    private float enabledColliderCenter;
    private float enabledColliderHeight;
    
    private void Start()
    {
        locomotionToggleInput.action.started += ToggleLocomotion;
        
        originalPlayerCapsuleScale = playerCapsuleGrower.localScale.y;
        
        // originalColliderCenter = playerCapsuleCollider.center.y;
        // originalColliderHeight = playerCapsuleCollider.height;
        
        enabledColliderCenter = -((originalColliderHeight / 4) - 0.25f);
        enabledColliderHeight = originalColliderHeight / 2;
    }

    private void ToggleLocomotion(InputAction.CallbackContext obj)
    {
        if (playerLocomotion)
        {
            playerLocomotion.disableMovement = !playerLocomotion.disableMovement;

            if (playerLocomotion.disableMovement)
            {
                playerCapsuleCollider.center = new Vector3(0, originalColliderCenter, 0);
                playerCapsuleCollider.height = originalColliderHeight;
                // playerCapsuleGrower.localScale = new Vector3(playerCapsuleGrower.localScale.x, playerCapsuleGrower.localScale.y * capsuleGrowerScale, playerCapsuleGrower.localScale.z);
            }
            else
            {
                // playerCapsuleCollider.center = new Vector3(0, 0, 0);
                // playerCapsuleCollider.height = 0.5f;
                playerCapsuleCollider.center = new Vector3(0, enabledColliderCenter, 0);
                playerCapsuleCollider.height = enabledColliderHeight;
                // playerCapsuleGrower.localScale = new Vector3(playerCapsuleGrower.localScale.x, originalPlayerCapsuleScale, playerCapsuleGrower.localScale.z);
            }
        }
    }
}
