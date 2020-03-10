using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ArmorSetsList", menuName = "Game Stats/Armor Sets List")]
public class ArmorSetsList : ScriptableObject {
	public ArmorSetInfo[] armorSets;

	public WeaponList GetArmorSet (ArmorSets type) {
		foreach (ArmorSetInfo asi in armorSets) {
			if (asi.type == type) return asi.armorParts;
		}
		return null;
	}
}

[System.Serializable]
public struct ArmorSetInfo {
	public ArmorSets type;
	public WeaponList armorParts;
}
