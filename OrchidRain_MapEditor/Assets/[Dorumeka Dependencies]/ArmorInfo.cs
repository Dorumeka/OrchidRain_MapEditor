using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct ArmorSpawnInformation {
	public ArmorSets armorSets;
	[Range(0f, 1f)]
	public float armorChance;
	public bool overrideHair;
	[Range(0f, 1f)]
	public float chanceForHead;
	[Range(0f, 1f)]
	public float chanceForChest;
	[Range(0f, 1f)]
	public float chanceForArms;
	[Range(0f, 1f)]
	public float chanceForBelly;
	[Range(0f, 1f)]
	public float chanceForPelvis;
	[Range(0f, 1f)]
	public float chanceForLegs;
}