﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Disrupt : Payload {
    public Names.Status _status;

    void Start() {
        _abilityType = Types.Ability.DISRUPT;
    }

    public override void DoEffect(GameObject caster, GameObject target, Transform point) {
        this.caster = caster;
        this.target = target;
        this.point = point;
        if(_duration > 0) {
            StartCoroutine(DuraEffect());
        }
        else {
            Effect();
        }
    }

    protected override void Effect() {
        if(_area == 0) {
            //Do stuff to the target
        }
        else if(_area > 0) {
            List<GameObject> targets = GetAll(_targetType);
            for(int i = 0; i < targets.Count; ++i) {
                //Do stuff to the target
            }
        }
        Finish();
    }

    protected override IEnumerator DuraEffect() {
        while(_internal < _duration) {
            Effect();
            yield return new WaitForSeconds(TICK);
            _internal += TICK;
        }
        Finish();
    }

    protected override void Finish() {
        isDone = true;
        //Note: Statuses, when finished, are taken care of by themselves (they have an Undo method) in the Character
    }
}
