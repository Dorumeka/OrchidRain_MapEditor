using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour {
	[Space(5f)]
	[Header("Variables")]
	public int eventTriggerId;
	[Tooltip("-1: infinite")]
	public int repetitions = -1;

	private EventInfo eventInfo;

	public virtual void Start () {
		eventInfo = new EventInfo();
		eventInfo.transform = transform;
	}

	public virtual void ActivateTrigger () {
		if (repetitions != 0) {
			if (EventManager.eventManager) {
				EventManager.eventManager.TriggerEvent("Trigger_" + eventTriggerId, eventInfo);
			}
			if (repetitions > 0) repetitions--;
		}
	}
}
