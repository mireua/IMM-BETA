using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    
    // Start is called before the first frame update
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "opp"){
            playerMovement.enabled = false;
            FindObjectOfType<GameStatus>().EndStatus();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collisionInfo.collider.tag == "finish"){
            playerMovement.enabled = false;
            FindObjectOfType<GameStatus>().WinStatus();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
