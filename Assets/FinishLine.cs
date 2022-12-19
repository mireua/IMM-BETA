using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private AudioSource finishLine;
    void OnTriggerEnter(Collider collision){
       // GameObject hitObj = collider.gameObject;

        if(collision.CompareTag("Player")){
            finishLine.Play();
        }
    }
}
