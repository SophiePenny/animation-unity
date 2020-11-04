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
        anim.SetBool("walkleft", false);
        anim.SetBool("walkright", false);
        anim.SetBool("walkback", false);
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("walkleft", true);
            anim.SetBool("stand", false);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("walkright", true);
            anim.SetBool("stand", false);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("walkback", true);
            anim.SetBool("stand", false);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("stand", true);
        }
    }
}
