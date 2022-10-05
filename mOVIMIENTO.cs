using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mOVIMIENTO : MonoBehaviour
{

Animator anim;

    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.D)){
      if(GetComponent<SpriteRenderer>().flipX==true){
         GetComponent<SpriteRenderer>().flipX=false;
      }
        transform.Translate(0.02f,0,0);
        anim.SetBool("RunProject", true);
        anim.SetBool("JumpProject", false);
        anim.SetBool("idlProject", false);

     }

     else if(Input.GetKey(KeyCode.A)){
      if(GetComponent<SpriteRenderer>().flipX==false){
         GetComponent<SpriteRenderer>().flipX=true;
      }
        transform.Translate(-0.02f,0,0);
        anim.SetBool("RunProject", true);
        anim.SetBool("JumpProject", false);
        anim.SetBool("idlProject", false);
     }

     else if(Input.GetKeyDown(KeyCode.W)){
        transform.Translate(0,2,0);
        transform.Translate(0.02f,0,0);
        anim.SetBool("RunProject", false);
        anim.SetBool("JumpProject", true);
        anim.SetBool("idlProject", false);
     }

     else if(Input.GetKey(KeyCode.S)){
        transform.Translate(0,-0.02f,0);
        transform.Translate(0.02f,0,0);
        anim.SetBool("RunProject", false);
        anim.SetBool("JumpProject", false);
        anim.SetBool("idlProject", false);
     }

     else{
        anim.SetBool("RunProject", false);
        anim.SetBool("JumpProject", false);
        anim.SetBool("idlProject", true);
     }   

if(transform.position.y <= -6.55f){
   SceneManager.LoadScene("GameOver");
}

    }
    }

