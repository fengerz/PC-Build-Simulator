using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTips : MonoBehaviour
{
    public OnTrigger[] infoCanvas;

    public void ToggleTips(bool enabled) {
        if (enabled) {
            for (int i = 0; i < infoCanvas.Length; i++) {
                //true
                infoCanvas[i].requiredTag = "Player";
            }
        } else {
            for (int i = 0; i < infoCanvas.Length; i++) {
                //false
                infoCanvas[i].requiredTag = "GameController";
            }
        }
        
    }
}
