using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStartTrigger : EventTrigger {
	IEnumerator Start () {
		yield return new WaitForSeconds(0.1f);
		ActivateTrigger();
	}
}
