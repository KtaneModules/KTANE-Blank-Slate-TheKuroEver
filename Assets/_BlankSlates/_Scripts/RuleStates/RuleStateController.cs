﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RuleStateController : MonoBehaviour {

    protected BlankSlatesModule _module;

    protected void Awake() {
        _module = GetComponentInParent<BlankSlatesModule>();
    }

    public abstract IEnumerator OnStateEnter(Region pressedRegion);

    public abstract IEnumerator HandleRegionPress(Region pressedRegion);

    public virtual IEnumerator HandleTP(string command) {
        throw new System.NotImplementedException();
    }

    public virtual IEnumerator Autosolve() {
        throw new System.NotImplementedException();
    }

}
