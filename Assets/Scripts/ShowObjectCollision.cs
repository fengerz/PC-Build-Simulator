using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObjectCollision : MonoBehaviour
{
    private string tagController;
    
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == tagController) {
            gameObject.SetActive(true);
        } else {
            gameObject.SetActive(false);
        }
    }
}
