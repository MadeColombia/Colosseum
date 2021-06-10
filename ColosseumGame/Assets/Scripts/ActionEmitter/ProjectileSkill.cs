using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skill/ProjectileSkill")]
public class ProjectileSkill : Skill
{
    public Rigidbody projectile;
    public float speed;

    public override void Fire(GameObject emitter)
    {
        emitter.GetComponent<ProjectileLauncher>().Launch(this.projectile, this.speed);
    }
}