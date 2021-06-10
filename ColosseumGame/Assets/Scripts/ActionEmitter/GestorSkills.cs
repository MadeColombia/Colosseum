using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class GestorSkills :  MonoBehaviour 
{
    public Skill fireball;
    public Animator anim;

//Start is called before the first frame update
    void Start()
{

}

//Update is called once per frame
    void Update()
{
    if (Input.GetKeyDown("1"))
    {
        anim.SetBool("IsAttacking", true);
        this.fireball.Fire(this.gameObject);


    }
    else
    {
        anim.SetBool("IsAttacking", false);
    }

}
}
