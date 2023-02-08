using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] string _name;
    [SerializeField] Canvas _interactionPrompt;

    private void openPrompt()
    {
        _interactionPrompt.enabled = true;
    }
    private void closePrompt()
    {
         _interactionPrompt.enabled = false;
    }
}
