using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollwoplayer : MonoBehaviour
{
    public   Animator anim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("cameratriger"))
        {
            anim.SetBool("cameramove", true);
        }
        if (collision.CompareTag("cameratriger2"))
        {
            anim.SetBool("cameramove", false);
        }


    }
}