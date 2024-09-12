using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRunner : MonoBehaviour
{

    private Rigidbody2D playerRB;
    public float fuerzaSalto = 5f;
    public bool tocandoPasto =true;

    // Start is called before the first frame update
    void Start()
    {
        
        playerRB = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && tocandoPasto)
        {

            playerRB.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);

            tocandoPasto = false;


        }




    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        tocandoPasto = true;


        if (collision.gameObject.CompareTag("Obstaculo"))
        {
           
            Debug.Log("¡Perdiste!");
           
            SceneManager.LoadScene("GameOverScene");

        }


    }


  
}

