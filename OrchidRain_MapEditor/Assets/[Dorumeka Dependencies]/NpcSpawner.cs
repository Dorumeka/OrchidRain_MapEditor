using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSpawner : MonoBehaviour {
	public bool spawnAtStart = false;
	public Npc_Type npcType = Npc_Type.Grunt;
	public GameObject overrideSkin;
	public DoruStats overrideStats;
	public Ai_Type aiType = Ai_Type.Wander;
	public Waypoints_Behavior waypointsBehavior;
	public Ai_Weapon weapon = Ai_Weapon.Random;
	public GameObject overrideWeapon;
	public Faction faction;
	public DoruPersonalitySelector personality = DoruPersonalitySelector.Random;
	
	public ArmorSpawnInformation armorSpawnInfo;
	public HairOverrides hairOverrides;
	public HatOverrides hatOverrides;
	public SkinOverrides skinOverrides;
}
