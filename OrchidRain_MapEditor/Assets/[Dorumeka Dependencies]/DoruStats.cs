using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DoruStats", menuName = "Game Stats/Doru Stats")]
public class DoruStats : ScriptableObject {
	[Space(5f)]
	[Header("Movement")]
	public float walkSpeed = 0.6f;
	public float runSpeed = 3.5f;
	public float rotationSpeed = 8f;

	[Space(5f)]
	[Header("Wander Behavior")]
	public float minWanderDistance = 5f;
	public float maxWanderDistance = 10f;
	public float minWanderPause = 2f;
	public float maxWanderPause = 6f;
	public float wanderRate = 2f;

	[Space(5f)]
	[Header("Attack Behavior")]
	public float targetTooCloseReactionTime = 2f;
	public float minAttackMoveTime = 4f;
	public float maxAttackMoveTime = 8f;
	public float minAttackMoveDistance = 1f;
	public float maxAttackMoveDistance = 8f;
	public float viewDistance = 30f;

	[Space(5f)]
	[Header("Appearance")]
	public float minScale = 0.8325f;
	public float maxScale = 0.9675f;
	public float minBoobSize = 0.35f;
	public float maxBoobSize = 1.6f;
	public float minButtSize = 0.6f;
	public float maxButtSize = 1.75f;

	[Space(5f)]
	[Header("Voice")]
	[Range(0f, 1f)]
	public float voiceChance = 0.75f;
	[Range(0f, 1f)]
	public float pitchVariation = 0.1f;
}
