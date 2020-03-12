using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour {
	[Space(5f)]
	[Header("Base variables")]
	public bool spawnOnStart = true;
	public bool respawnable;
	public float respawnTime;
}
