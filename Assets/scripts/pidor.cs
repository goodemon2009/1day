using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI;


public class pidor : MonoBehaviour
{
    public float JumpForce = 1f;
    public Text AttemptsText;
    public int attempts = 0;
    private Rigidbody2D rb;
    private bool onground = true;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
}

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            if (onground == true){
                rb.AddForce(Vector3.up * JumpForce, ForceMode2D.Impulse);
        }
    }
}
    private void OnCollisionEnter2D(Collision2D collision){
    
        if (collision.gameObject.CompareTag("enemy"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.CompareTag("ground")){
            onground = true;
        }
        
}        
    private void OnCollisionExit2D(Collision2D collision){
        if (collision.gameObject.CompareTag("ground"))
        {
            onground = false;
        }
    }
}
