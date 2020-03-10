using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : EventTrigger {
	public float seconds;

	void Start () {
		StartCoroutine(CountTimer());
	}

	IEnumerator CountTimer () {
		yield return new WaitForSeconds(seconds);
		ActivateTrigger();
	}
}
