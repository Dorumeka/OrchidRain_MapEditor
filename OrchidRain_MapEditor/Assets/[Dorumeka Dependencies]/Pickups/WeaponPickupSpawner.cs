using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickupSpawner : PickupSpawner {
	[Space(5f)]
	[Header("Variables")]
	public PlayerWeapon weapon;
}
