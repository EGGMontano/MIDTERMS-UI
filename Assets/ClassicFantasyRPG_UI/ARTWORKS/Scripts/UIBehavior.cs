using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIBehavior : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public UIManager uiManager;
    public void OnPointerEnter(PointerEventData eventData)
    {
        uiManager.targetObj = this.gameObject;
        uiManager.IncreaseSize();
        Debug.Log("Pointer Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        uiManager.ReturnSize();
        uiManager.targetObj = null;
        Debug.Log("Pointer Exit");
    }
}
