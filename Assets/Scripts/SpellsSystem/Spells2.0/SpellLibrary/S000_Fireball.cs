﻿using UnityEngine;
using System;
using System.Collections.Generic;

namespace SpellSystem {
    public class S000_Fireball : Spell {
        public string spawn; //Eventually place this into SpellStats
        public override void Cast(GameObject caster, GameObject target, Vector3 point) {
            //Target is not used for Fireball (It is a directional skill shot)
            if(caster == null) {
                Debug.Log(this + ": \n" + "Caster is null...");
            }
            if(!isCastable) {
                Debug.Log(this + " is not castable yet.");
                return;
            }
            isCastable = false;
            GameObject proj = SpellUtility.SpawnProjectile("Spells/" + spawn, this.transform, caster.transform.position, Quaternion.identity);
            proj.GetComponent<Projectile>().Move(caster, point);
            StartCoroutine(Cooldown());
        }
    }
}

