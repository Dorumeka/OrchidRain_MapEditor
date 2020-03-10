using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaTrigger : EventTrigger {
	void OnTriggerEnter (Collider c) {
		if (c.transform.tag == "Player") {
			ActivateTrigger();
		}
	}
}
