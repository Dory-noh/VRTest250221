using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatorHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAniAction;
    public InputActionProperty gripAniAction;
    public Animator handAnimator;

    private readonly int hashTrigger = Animator.StringToHash("Trigger");
    private readonly int hashGrip = Animator.StringToHash("Grip");

    void Start()
    {
        handAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        float triggerValue = pinchAniAction.action.ReadValue<float>();
        handAnimator.SetFloat(hashTrigger, triggerValue);
        float gripValue = gripAniAction.action.ReadValue<float>();
        handAnimator.SetFloat(hashGrip, gripValue);
    }
}
