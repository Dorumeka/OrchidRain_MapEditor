using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour {
	public bool spawnAtStart = false;
	public Vehicle_Type vehicleType = Vehicle_Type.HeavyMecha;
	public Vehicle_Weapon_Main mainWeapon;
	public Vehicle_Weapon_Secondary secondaryWeapon;
	public Pilot_Weapon pilotWeapon;

	[HideInInspector]
	public NpcSpawner npcSpawner;

	public List<GameObject> vehicles = new List<GameObject>();
}
