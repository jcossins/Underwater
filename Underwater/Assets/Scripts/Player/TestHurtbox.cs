﻿using UnityEngine;
using System.Collections;

public class TestHurtbox : Hurtbox {
    override public void TakeDamage(float damage)
    {
        owner.LoseHealth(damage);
    }

    override public void TakeHit(float hitlag, float hitstun, Vector2 knockback)
    {
        if(hitstun > 0)
            owner.ActionFsm.ChangeState(new HitState(owner, hitlag, hitstun, knockback, owner.ActionFsm));
        else
            owner.selfBody.velocity = knockback;
    }

    override public void ApplyEffect(Parameters.Effect effect)
    {
    }
}
