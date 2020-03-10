using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EquipedWeapons", menuName = "Game Stats/Equiped Weapons")]
public class EquipedWeapons : ScriptableObject {
	public WeaponStartingInfo[] startingWeapons;
	public ItemStartingInfo [] startingItems;
}

[System.Serializable]
public struct WeaponStartingInfo {
	public PlayerWeapon weaponType;
	public int startingAmmoPrimary;
	public int startingAmmoSecondary;
	public bool startingWeaponOnHand;
}


[System.Serializable]
public struct ItemStartingInfo {
	public PlayerItems itemType;
	public int startingAmmo;
}
