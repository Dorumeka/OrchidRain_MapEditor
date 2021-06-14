using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CounterReceiver))]
public class CounterTrigger : EventTrigger {
	public int countValue;

	[TextArea]
	public string note = "Make sure that this component's Event Trigger Id value is different from the Counter Receiver's own Event Trigger Id. If they are the same, this will create an infinite loop and could make the game crash.";
}
