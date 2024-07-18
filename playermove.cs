using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermove : MonoBehaviour
{
    Rigidbody2D rb;
    public static bool gameOver = false;
    public score Scoretext;
    public GameObject gameoverpanel;
    // Start is called before the first frame update
    void Start()
    {

        gameoverpanel.SetActive (false);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if (gameOver) return;


        var speed = 0.05f;
        transform.position = new Vector3(
         transform.position.x + speed,
         transform.position.y,
         transform.position.z
         );
       

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(0f, 3f);
            if (gameOver) return;
        }
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  print("onTriggerEnter2D" + collision.tag);
        
            if (collision.CompareTag("pipes"))
            {
                Scoretext.Scoreup();
            }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        gameoverpanel.SetActive(true);
          gameOver = true;

        //rb.velocity = new Vector2(0f, 0f);
        //rb.gravityScale = 0;
        Time.timeScale = 0f;

    }
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
        gameOver = false;
        Time.timeScale = 1f;

    }
}
