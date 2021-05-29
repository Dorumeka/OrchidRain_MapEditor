using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionObject : MonoBehaviour {
	[HideInInspector]
	public MissionObjectiveType objectiveType;

	[Header("Generic Variables")]
	[Range(1, 20)]
	public int objectiveNumber = 1;
	public string objectiveName;
	public bool needsAnotherMission;
	[Tooltip("-1: no mission needed || 0: all other missions needed")]
	public int missionNeeded = -1;
	public bool failIfRequirementNotMet = true;
}
