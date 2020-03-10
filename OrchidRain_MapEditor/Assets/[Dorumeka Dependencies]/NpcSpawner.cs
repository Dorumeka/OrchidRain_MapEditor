using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawner : MonoBehaviour {
	public bool spawnAtStart = true;
	public Npc_Type npcType;
	public GameObject overrideSkin;
	public DoruStats overrideStats;
	public Ai_Type aiType = Ai_Type.Wander;
	public Waypoints_Behavior waypointsBehavior;
	public Ai_Weapon doruWeapon = Ai_Weapon.Random;
	public GameObject overrideWeapon;
	public Faction doruFaction;
	
	public ArmorSpawnInformation armorSpawnInfo;
	public HairOverrides hairOverrides;
	public HatOverrides hatOverrides;
	public SkinOverrides skinOverrides;

	public List<Transform> waypoints = new List<Transform>();
}
