using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloack1move : MonoBehaviour
{
    public Animator buttonanim1;
    public Animator buttonanim2;
    public Animator buttonanim3;
    public Animator buttonanim4;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("triger1"))
        {
            buttonanim1.SetBool("righttoleft", true);
            anim2.SetBool("uptodown", true);

        }
        if (collision.CompareTag("triger2"))
        {
            buttonanim2.SetBool("righttoleft2", true);
            anim2.SetBool("uptodown", false);

        }
        if (collision.CompareTag("triger3"))
        {
            
            anim3.SetBool("move", true);
            buttonanim3.SetBool("righttoleft3", true);
        }
        if (collision.CompareTag("triger4"))
        {

            anim3.SetBool("move", false);
            buttonanim3.SetBool("righttoleft3", false);
        }
        if (collision.CompareTag("triger5"))
        {

            anim4.SetBool("righttoleft", true);
            buttonanim4.SetBool("righttoleft", true);
        }
        if (collision.CompareTag("triger6"))
        {

            anim4.SetBool("righttoleft", false);
            buttonanim4.SetBool("righttoleft", false);
        }


    }

}
