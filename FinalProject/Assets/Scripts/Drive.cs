using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public static GameObject controlledBy;
    public float speed = 2.0f;
    public float rotationSpeed = 100.0f;
    Animator anim;

    void Start()
    {
        anim = this.GetComponent<Animator>();

    }

    void Awake()
    {
        // anim = this.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
       
    }

   void Update(){
     if(controlledBy != null) return;
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.fixedDeltaTime;
        rotation *= Time.fixedDeltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        if (translation != 0)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("characterSpeed", translation);
        }
        else
        {
            anim.SetBool("isWalking", false);
            anim.SetFloat("characterSpeed", 0);
        }

    if(Input.GetKeyDown(KeyCode.Space)){
           anim.SetBool("isJumping", true);
           Debug.Log("Space key is pressed.");
       }else if(Input.GetKeyUp(KeyCode.Space)){
           anim.SetBool("isJumping", false);
       }
       if(Input.GetKeyDown(KeyCode.LeftShift)){
           anim.SetBool("isRunning", true);
       }else if(Input.GetKeyUp(KeyCode.LeftShift)){
           anim.SetBool("isRunning", false);
       }
       
   }
}

