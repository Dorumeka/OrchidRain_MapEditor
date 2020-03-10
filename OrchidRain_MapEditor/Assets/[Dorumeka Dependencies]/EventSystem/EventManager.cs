using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

[System.Serializable]
public struct EventInfo {
	public Transform transform;
	//public VN_Dialogue dialogue;
}

public class EventManager : MonoBehaviour {
	private Dictionary<string, Action<EventInfo>> eventDictionary;

	public static EventManager eventManager;
	void Awake () {
		if (eventManager == null) {
			eventManager = this;
			Init();
		}
		else if (eventManager != this) Destroy(gameObject);
	}

	void Init () {
		if (eventDictionary == null) eventDictionary = new Dictionary<string, Action<EventInfo>>();
	}

	public void StartListening (string eventName, Action<EventInfo> listener) {
		Action<EventInfo> thisEvent = null;
		if (eventDictionary.TryGetValue (eventName, out thisEvent)) {
			thisEvent += listener;
			eventDictionary[eventName] = thisEvent;
			//Debug.Log("Added event: " + eventName);
		}
		else {
			thisEvent += listener;
			eventDictionary.Add(eventName, thisEvent);
			//Debug.Log("Added new event to the dictionary: " + eventName);
		}
	}

	public void StopListening (string eventName, Action<EventInfo> listener) {
		if (eventManager == null) return;
		Action<EventInfo> thisEvent = null;
		if (eventDictionary.TryGetValue (eventName, out thisEvent)) {
			thisEvent -= listener;
			eventDictionary[eventName] = thisEvent;
		}
	}

	public void TriggerEvent (string eventName, EventInfo eventInfo) {
		Action<EventInfo> thisEvent = null;
		if (eventDictionary.TryGetValue (eventName, out thisEvent)) {
			thisEvent.Invoke(eventInfo);
		} else {
			//Debug.Log("Failed to invoke: " + eventName);
		}
	}
}
