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
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("walkleft", true);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("walkright", true);
        }

        if(Input.GetKey("d"))
        {
            anim.SetBool("walkright2", true);
        }

        if(Input.GetKey("a"))
        {
            anim.SetBool("walkleft2", true);
        }
    }
}
