using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class player2movment : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rp;
    float speed = 6f;
    public GameObject player;
    public Animator anim;
    bool isjump = false;
    float jump = 8f;
    public Animator door1anim;
    public Animator door2anim;

    void Start()
    {
        rp = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
  
    }
    private void FixedUpdate()
    {
        float ver = Input.GetAxis("Vertical");
        rp.velocity = new Vector2(ver * speed, rp.velocity.y);

        if (Input.GetKey(KeyCode.UpArrow) && isjump == false)
        {
            rp.velocity = new Vector2(0, jump);
            isjump = true;

        }
        if (Mathf.Abs(rp.velocity.y) < 0.01f)
        {
            isjump = false;
        }

        if (ver < 0)
        {
            player.transform.localScale = new Vector3(-2, 2, 0);

        }
        if (ver > 0)
        {
            player.transform.localScale = new Vector3(2, 2, 0);

        }

        if (ver > 0 || ver < 0)
        { anim.SetBool("idletorun", true); }
        else if (ver == 0)
        { anim.SetBool("idletorun", false); }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("trap"))
        {
            SceneManager.LoadScene("Level1");
        }
        
        
            if (collision.CompareTag("trap"))
            {
                SceneManager.LoadScene("Level1");
            }


            if (collision.CompareTag("doortriger1"))
            {
                
                door1anim.SetBool("closetoopen", true);

            }

            if (collision.CompareTag("doortriger2"))

            {
                
                door2anim.SetBool("closetoopen2", true);
            }


        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("doortriger1"))
        {

            door1anim.SetBool("closetoopen", false);

        }
        if (collision.CompareTag("doortriger2"))
        {

            door2anim.SetBool("closetoopen2", false);

        }
    }
}

