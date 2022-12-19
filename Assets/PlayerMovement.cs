using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
 [SerializeField] private AudioSource collide;
    public float wMovement = 500f;
    public float sideMovement = 500f;
    public float gravityScale = 5;
    public float jumpForce = 20f;
 [SerializeField] private AudioSource sideToSide;
    public bool gameOver;
    
    private void Start()
    {
        
    }


    void FixedUpdate() {
        rigidBody.AddForce(0, 0, wMovement * Time.deltaTime);

        if (Input.GetKey("a")){
            
            rigidBody.AddForce(-sideMovement * Time.deltaTime, 0, 0);
             sideToSide.Play();
        }

        if (Input.GetKey("d")){

            rigidBody.AddForce(sideMovement * Time.deltaTime, 0, 0);
             sideToSide.Play();
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            rigidBody.AddForce(0, 0, 100f * Time.deltaTime);
        }

        if (rigidBody.position.y < -4f){
            FindObjectOfType<GameStatus>().EndStatus();
        }
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("opp")){

            Debug.Log("Game over");
            gameOver = true;
            collide.Play();

        }
    }
}
