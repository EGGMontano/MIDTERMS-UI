using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject sword;
    public float swordMaxSize, swordDefaultSize, swordAnimationTime, swordShakeRandomness, swordFloatElasticity, swordMiniSize;
    public Vector3 swordRotateTo, swordRotate2To, swordShakeStrength, swordPunch;
    public int swordVibrato;
    public bool swordPunchSnapping = true;

    public void scaleSword()
    {
        sword.transform.DOScale(swordMaxSize, swordAnimationTime);
    }
    public void rotateSword()
    {
        sword.transform.DORotate(swordRotateTo, swordAnimationTime, RotateMode.Fast);
    }
    public void shakeSword()
    {
        sword.transform.DOShakePosition(swordAnimationTime, swordShakeStrength, swordVibrato, swordShakeRandomness);
    }
    public void punchSword()
    {
        sword.transform.DOPunchPosition(swordPunch, swordAnimationTime, swordVibrato, swordFloatElasticity, swordPunchSnapping);
    }
    public void miniSword()
    {
        sword.transform.DOScale(swordMiniSize, swordAnimationTime);
    }
    public void rotateSwordTwo()
    {
        sword.transform.DORotate(swordRotate2To, swordAnimationTime, RotateMode.Fast);
    }
}
