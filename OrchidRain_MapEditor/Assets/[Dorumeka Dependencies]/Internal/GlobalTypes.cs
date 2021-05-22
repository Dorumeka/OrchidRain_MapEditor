using UnityEngine;
using System.Collections.Generic;

public enum Ai_Weapon {
	Random,
	Unarmed,
	TR8_R,
	Dartgun,
	Makarov,
	MakarovSilenced,
	SMG,
	KSG,
	Doragon,
	CrossbowGun
};

public enum PlayerWeapon {
	Unarmed,
	TR8_R,
	Dartgun,
	Makarov,
	MakarovSilenced,
	SMG,
	KSG,
	Doragon,
	CrossbowGun
}

public enum PlayerItems {
	CovertModem,
	GenericDildo
}

public enum Ai_Type {
	Wander,
	Guard,
	Waypoints
};

public enum Waypoints_Behavior {
	OnceThenWander,
	OnceThenGuard,
	PingPong,
	StartOver,
	Random
};

public enum Npc_Type {
	Random,
	Grunt,
	Officer,
	Naked,
	GruntHalloween,
	OfficerHalloween,
	CombatMedicA,
	CombatMedicB,
	LewdDoru,
	NekoDoru,
	Underwear
};

public enum Faction {
	OrchidRainCorp,
	CruzInstitute,
	Monsters
};

public enum HitBoxType {
	Main,
	Body,
	Head,
	Arm_L,
	Arm_R,
	Leg_L,
	Leg_R,
	Player
};

public enum MissionObjectiveType {
	Assassinate,
	Protect,
	Interact,
	UseItem,
	Collect,
	Arrive,
	Destroy
};

public enum DropableItemType {
	MedPack_Small,
	MedPack_Medium
};

public enum DamageType {
	Ragdoll,
	Gibbing,
	Dismember_Slash,
	Dismember_Shot,
	PassOut,
	InstaGib,
	Limp,
	Poison,
	BodyDetonation
};

public enum CauseOfDeath {
	StabBody,
	StabFace,
	Faint,
	Ragdoll
};

public enum HurtType {
	Body_Shot,
	Hip_Shot,
	LegL_Shot,
	LegR_Shot,
	ArmL_Shot,
	ArmR_Shot,
	Head_Shot,
	Body_Slash
};

public enum UiEquipmentType {
	NonLethal,
	Lethal,
	ItemAmmo,
	ItemAmmoless
};

public enum BoneType {
	Pelvis,
	Spine0,
	L_Thigh,
	L_Calf,
	L_Foot,
	R_Thigh,
	R_Calf,
	R_Foot,
	Spine1,
	Spine2,
	L_UpperArm,
	L_LowerArm,
	L_Hand,
	R_UpperArm,
	R_LowerArm,
	R_Hand,
	Neck,
	Head,
	Face
};

public enum GibType {
	Arm_L,
	Arm_R,
	HeadWhole,
	Leg_L,
	Leg_R,
	TorsoRipped,
	Pelvis,
	TorsoWhole,
	Legs,
	Half_L,
	Half_R
};

public enum GibSetType {
	AllRipped,
	Halves,
	LegsTorso,
	LowerRipped,
	UpperRipped
};

public enum VoiceClip {
	//Alive
	aIdle,
	aChat_Question,
	aChat_Answer,
	aStartled,
	aThreat,
	aHurt,
	aMeleeAttack,
	aTrouble,
	aSurrender,
	//Deaths
	dGeneric,
	dFaint,
	dFaint_Muffled,
	dViolent,
	dDismember_Arm,
	dDismember_Leg,
	dChoking,
	dDrowning,
	dMuffled,
	dCrazy,
	dFalling,
	//Sex
	sMumble,
	sMoan_Breathe,
	sMoan_Low,
	sMoan_High,
	sOrgasm
};

public enum DoruPersonality {
	Generic,
	Dominating,
	Shy
};
public enum DoruPersonalitySelector {
	Generic,
	Dominating,
	Shy,
	Random
};

public enum MapType {
	Mission,
	AiBattle
};

public enum VisualNovelAnimation {
	None,
	FromLeft,
	FromRight,
	FadeIn,
	Shake
};

public enum ArmorSets {
	OrchidRain_Standard,
	CruzInstitute_Standard
};

/*
*	=Sounds=
*/

public enum ButtonSoundType {
	Sound1,
	Sound2,
	Sound3
};

public enum DoorSoundType {
	Sound1,
	Sound2,
	Sound3
};

public enum HealthState {
	Alive,
	PassedOut,
	Dead,
	Captured,
	Saved,
	Limp
};

public enum HairStyle {
	None,
	PlainStraight,
	Messy,
	AShape,
	Boring,
	TidyHair,
	StraightAndBack,
	TightFringe,
	IdolTails,
	PonyTail
};

public enum SkinColor {
	None,
	Normal,
	Light,
	Dark,
	Darker
}

[System.Serializable]
public struct SkinOverrides {
	public SkinColor skinColor;
	public Color[] colors;
	public Color[] eyeColors;
}

[System.Serializable]
public struct HairOverrides {
	public HairStyle style;
	public Color[] colors;
}

[System.Serializable]
public struct HatOverrides {
	[Range(0f, 1f)]
	public float hatChance;
}

public enum HealthPickups {
	MedPack_Small,
	MedPack_Medium
}

public enum GameMusic {
	None,
	LevelA_TheStartOfRedsJourney,
	LevelB_SecretLab
}

public enum AudioType {
	Music,
	SFX,
	UI,
	Voice
}

public enum CaptureRigComponent {
	Body,
	LeftHand,
	RightHand,
	LeftFoot,
	RightFoot,
	LeftArmTarget,
	RightArmTarget,
	LeftLegTarget,
	RightLegTarget
}

[System.Serializable]
public struct CharacterCustomizationInfo {
	public string name;
	public int characterId;
	public Gender gender;
	public Npc_Type character;
	public DoruPersonality personality;
	public ArmorSpawnInformation armorInfo;
	public Ai_Weapon weapon;
	[SerializeField] public SerializableColor skinColor;
	[SerializeField] public SerializableColor eyeColor;
	public HairStyle hairStyle;
	[SerializeField] public SerializableColor hairColor;
	public CharacterProportions proportions;
	//hats and accesories too
	[SerializeField] public List<StoredAccessory> storedAccessories;
}

[System.Serializable]
public struct CharacterProportions {
	public float scale;
	public float height;
	public float boobSize;
	public float buttSize;
	public float dickSize;
}

public enum Gender {
	Female,
	Male
}

[System.Serializable]
public class SerializableColor {
	public float _r;
	public float _g;
	public float _b;
	public float _a;

	public Color Color {
		get {
			return new Color(_r, _g, _b, _a);
		}
		set {
			_r = value.r;
			_g = value.g;
			_b = value.b;
			_a = value.a;
		}
	}

	public SerializableColor () {
		_r = 1f;
		_g = 1f;
		_b = 1f;
		_a = 1f;

		/*_r = Random.Range(0f, 1f);
		_g = Random.Range(0f, 1f);
		_b = Random.Range(0f, 1f);
		_a = 1f;*/

	}

	public SerializableColor (float r, float g, float b, float a = 0f) {
		_r = r;
		_g = g;
		_b = b;
		_a = a;
	}

	public SerializableColor (Color color) {
		_r = color.r;
		_g = color.g;
		_b = color.b;
		_a = color.a;
	}
}

public enum Expression {
	Idle,
	Happy,
	Angry,
	Sad,
	Pain,
	Scared,
	Embarrassed,
	Sex_Idle,
	Sex_Low,
	Sex_High,
	Orgasm,
	PostOrgasm,
	Talk
}

public enum SexPoses {
	Study,
	PassedOut,
	Trashed,
	UpsideDown
}

public enum SexRigs {
	GagRack
}

public enum GameCharacters {
	Red,
	Vanessa,
	CCruz,
	Vickard
}

public enum DickType {
	None,
	Dildo
}

[System.Serializable]
public class StoredAccessory {
	public BoneType boneType;
	public int id;
	public bool active = true;
	public SerializableColor color;
}

public enum Vehicle_Weapon_Main {
	None,
	HeavyMecha_BigCannon,
	HeavyMecha_TwinShooter
}

public enum Vehicle_Weapon_Secondary {
	None,
	HeavyMecha_HeavyTurret,
	HeavyMecha_Laser
}

public enum Vehicle_Type {
	Random,
	HeavyMecha
}

public enum Pilot_Weapon {
	None,
	Random,
	Makarov
}