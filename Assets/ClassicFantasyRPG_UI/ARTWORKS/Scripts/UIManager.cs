using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public GameObject targetObj;
    public float scaleMaxSize, scaleDefaultSize, scaleAnimationTime;

    public void IncreaseSize()
    {
        targetObj.transform.DOScale(scaleMaxSize, scaleAnimationTime);
    }

    public void ReturnSize()
    {
        targetObj.transform.DOScale(scaleDefaultSize, scaleAnimationTime);
    }
}
