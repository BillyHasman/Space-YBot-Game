using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sit : MonoBehaviour
{
   
    public GameObject character;
    public GameObject anchor;
    bool isWalkingTowards = false;
    bool sittingOn = false;
    Animator anim;

    void Start()
    {
        anim = character.GetComponent<Animator>();
    }

    void Update()
    {
        if(isWalkingTowards){
            AutoWalkingTowards();
        }
    }

    void OnMouseDown() {
        if(!sittingOn){
            anim.SetBool("isWalking", true);
            anim.SetFloat("characterSpeed", 1.0f);
            isWalkingTowards = true;
            Drive.controlledBy = this.gameObject;
        }
        else{
            anim.SetBool("isSitting", false);
            sittingOn = false;
            isWalkingTowards = false;
            Drive.controlledBy = null;
        }
    }

    void AutoWalkingTowards(){
        Vector3 targetDir;
        targetDir = new Vector3(
            anchor.transform.position.x - character.transform.position.x, 0f,
            anchor.transform.position.z - character.transform.position.z
        );
        Quaternion rot = Quaternion.LookRotation(targetDir);
        character.transform.rotation = Quaternion.Slerp(character.transform.rotation,
        rot,
        0.05f);

    if (Vector3.Distance(character.transform.position, anchor.transform.position) < 0.8f){
        anim.SetBool("isSitting", true);
        anim.SetBool("isWalking", false);
        character.transform.rotation = anchor.transform.rotation;
        isWalkingTowards = false;
        sittingOn = true;
    }

    }
    void FixedUpdate() {
        AnimLerp();    
    }

    void AnimLerp(){
        if(!sittingOn) return;
        if(Vector3.Distance(character.transform.position, anchor.transform.position) > 0.1f){
            character.transform.rotation = Quaternion.Lerp(character.transform.rotation,
            anchor.transform.rotation,
            Time.deltaTime * 0.5f);
            
            character.transform.position = Vector3.Lerp(character.transform.position,
            anchor.transform.position,
            Time.deltaTime * 0.5f);
        }
        else{
        character.transform.position = anchor.transform.position;
        character.transform.rotation = anchor.transform.rotation;
        }
    }
    
}
