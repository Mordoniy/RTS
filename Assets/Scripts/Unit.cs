﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Unit : MonoBehaviour
{
    public float hp, damage, speed, armor;
    public NavMeshAgent agent;

    void Start()
    {

    }

    public virtual void Update()
    {

    }

    public abstract void ShowInfo();

    public void SetTargetPosition(Vector3 position)
    {
        NavMeshPath path = new NavMeshPath();
            if (agent.CalculatePath(position, path))
            {
                agent.SetPath(path);
            }

    }
    
}
