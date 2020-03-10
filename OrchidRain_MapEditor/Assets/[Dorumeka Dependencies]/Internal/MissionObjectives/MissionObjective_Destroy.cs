using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class MissionObjective_Destroy : MissionObject {
	[Space(10f)]
	[Header("Dependencies")]
	public GameObject destructionFx;
	public GameObject destroyedObject;

	[Space(10f)]
	[Header("Variables")]
	public int objectHP;
	public float explosionScale = 1f;
}
