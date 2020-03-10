using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponList", menuName = "Game Stats/Weapon List")]
public class WeaponList : ScriptableObject {
	public WeaponInfo[] weapons;
}

[System.Serializable]
public struct WeaponInfo {
	public GameObject weapon;
	public GameObject menuInfo;
}
