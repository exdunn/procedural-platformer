﻿using UnityEngine;
using System;
using System.Collections.Generic;

namespace SpellSystem {
    public class P006_Quark : Projectile {
        public override void Dissipate() {
            //Put death stuff here
            Die();
        }

        protected override void OnCollide(GameObject target) {
            SpellUtility.Damage(target, _stats.GetDamage());
            Dissipate();
        }

        protected override void OnLocation() {
            //Not used
            Dissipate();
        }

        protected override void OnOutOfRange() {
            //Not used
            Dissipate();
        }
    }
}

