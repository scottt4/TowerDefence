﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : EnemyMovement
{
    //public int damage;

    //private Animator animator;
    //private Transform target;
    //private bool skipMove;

    //protected override void Start()
    //{
    //    animator = GetComponent<Animator>();
    //    target = GameObject.FindGameObjectWithTag("Tower").transform;
    //    base.Start();
    //}


    //protected override void AttemptMove<T>(int xDir, int yDir)
    //{
    //    if (skipMove)
    //    {
    //        skipMove = false;
    //        return;
    //    }

    //    base.AttemptMove<T>(xDir, yDir);
    //    skipMove = true;

    //}

    //public void MoveEnemy()
    //{
    //    int xDir = 0;
    //    int yDir = 0;

    //    if (Mathf.Abs(target.position.x - transform.position.x) < float.Epsilon)
    //        yDir = target.position.y > transform.position.y ? 1 : -1;
    //    else xDir = target.position.x > transform.position.x ? 1 : -1;

    //    AttemptMove<EnemyMovement>(xDir, yDir);

    //}

    //protected override void OnCantMove<T>(T component)
    //{
    //    TowerHealth hitTower = component as TowerHealth;

    //    hitTower.TakeDamage(damage);

    //}
}
