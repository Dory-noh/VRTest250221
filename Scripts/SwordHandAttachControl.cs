using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SwordHandAttachControl : MonoBehaviour
{
    XRGrabInteractable grabInteractable;
    public Transform leftHandAttachment;
    public Transform rightHandAttachment;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(ChangeAttachment);
    }

    public void ChangeAttachment(SelectEnterEventArgs args)
    {
        if(args.interactorObject.transform.tag == "Left Hand")
        {
            grabInteractable.attachTransform = leftHandAttachment.transform;
        }
        else if(args.interactorObject.transform.tag == "Right Hand")
        {
            grabInteractable.attachTransform = rightHandAttachment.transform;
        }
    }
}
