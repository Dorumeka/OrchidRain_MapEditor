using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveReceiver : EventReceiver {
	[Space(5f)]
	[Header("Variables")]
	[Tooltip("This will only affect a pending objective. Once a mission objective has either succeed or failed it cannot be modified.")]
	public int objectiveNumber;
	public bool success = true;
}
