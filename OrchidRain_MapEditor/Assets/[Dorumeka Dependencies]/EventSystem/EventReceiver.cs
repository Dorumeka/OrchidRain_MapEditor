using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventReceiver : MonoBehaviour {
	[Space(5f)]
	[Header("Variables")]
	public int eventTriggerId;

	void OnEnable () {
		StartCoroutine(WaitToEnable());
	}
	void OnDisable () {
		if (EventManager.eventManager) EventManager.eventManager.StopListening("Trigger_" + eventTriggerId, TriggerReceiver);
		//StartCoroutine(WaitToDisable());
	}

	IEnumerator WaitToEnable () {
		yield return null;
		if (EventManager.eventManager) EventManager.eventManager.StartListening("Trigger_" + eventTriggerId, TriggerReceiver);
	}

	/*IEnumerator WaitToDisable () {
		yield return null;
		if (EventManager.eventManager) EventManager.eventManager.StopListening("Trigger_" + eventTriggerId, TriggerReceiver);
	}*/

	public virtual void TriggerReceiver (EventInfo eventInfo) {

	}
}
