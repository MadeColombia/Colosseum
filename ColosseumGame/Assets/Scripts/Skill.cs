using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : ScriptableObject
{
    public string skillName;

    public abstract void Fire(GameObject emitter);
}

