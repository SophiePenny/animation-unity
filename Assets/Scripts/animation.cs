using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {  
        anim.SetBool("stand", true);
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("walkleft", true);
            anim.SetBool("stand", false);
        }
        else
        {
            anim.SetBool("walkleft", false);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("walkright", true);
            anim.SetBool("stand", false);
        }
        else
        {
            anim.SetBool("walkright", false);
        }

        if(Input.GetKey("d"))
        {
            anim.SetBool("walkright2", true);
            anim.SetBool("stand", false);
        }
        else
        {
            anim.SetBool("walkright2", false);
        }

        if(Input.GetKey("a"))
        {
            anim.SetBool("walkleft2", true);
            anim.SetBool("stand", false);
        }
        else
        {
            anim.SetBool("walkleft2", false);
        }
    }
}
