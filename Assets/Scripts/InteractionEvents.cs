using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Handles;

public class InteractionEvents : MonoBehaviour
{
    [SerializeField] Text interactionText;
    [SerializeField] string interactionFunctionName;
    [SerializeField] public TMP_Text log;
    [SerializeField] public ScrollRect LogWindow;

    private string interactionSentence;

    public string InteractionSentence
    {
        get { return interactionSentence; }
    }
    #region HoverEvents
    public void Highlight()
    {
        interactionText.color = Color.green;
    }
    public void UnHighlight()
    {
        interactionText.color = Color.white;
    }
    #endregion

    public void InvokeInteraction()
    {
        Invoke(interactionFunctionName, 0f);
        Invoke("UpdateLog", 0f);
    }
    public void UpdateLog()
    {
        log.text += interactionSentence;
        LogWindow.ScrollToBottom();
    }

    #region Doors
    public void DoorOpen()
    {
        interactionSentence = "Vous ouvrez la <#0000FF>porte</color><br>";
    }

    public void DoorClose()
    {
        interactionSentence = "Vous fermé la <#0000FF>porte</color><br>";
    }
    public void DoorLookThrough()
    {
        Debug.Log("LookThroughDoor");
    }
    #endregion
}
