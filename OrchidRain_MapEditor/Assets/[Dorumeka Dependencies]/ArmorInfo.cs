using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct ArmorSpawnInformation {
	public ArmorSets armorSets;
	[Range(0f, 1f)]
	public float armorChance;
	[Range(0f, 1f)]
	public float chanceForHead;
	[Range(0f, 1f)]
	public float chanceForChest;
	[Range(0f, 1f)]
	public float chanceForBack;
	[Range(0f, 1f)]
	public float chanceForUpperArm_L;
	[Range(0f, 1f)]
	public float chanceForUpperArm_R;
	[Range(0f, 1f)]
	public float chanceForLowerArm_L;
	[Range(0f, 1f)]
	public float chanceForLowerArm_R;
	[Range(0f, 1f)]
	public float chanceForBelly;
	[Range(0f, 1f)]
	public float chanceForPelvis;
	[Range(0f, 1f)]
	public float chanceForButt;
	[Range(0f, 1f)]
	public float chanceForThigh_L;
	[Range(0f, 1f)]
	public float chanceForThigh_R;
	[Range(0f, 1f)]
	public float chanceForCalf_L;
	[Range(0f, 1f)]
	public float chanceForCalf_R;
}