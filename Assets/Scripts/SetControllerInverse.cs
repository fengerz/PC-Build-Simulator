using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetControllerInverse : MonoBehaviour
{
    public GameObject[] controllers = new GameObject[6];

    public void ToggleControllers(bool enabled) {
        if (!enabled) {
            for (int i = 0; i < controllers.Length; i++) {
                if (i < 3) {
                    controllers[i].SetActive(true);
                } else {
                    controllers[i].SetActive(false);
                }
            }

        } else {
            for (int i = 0; i < controllers.Length; i++) {
                if (i < 3) {
                    controllers[i].SetActive(false);
                } else {
                    controllers[i].SetActive(true);
                }
            }
        }
    }
}
