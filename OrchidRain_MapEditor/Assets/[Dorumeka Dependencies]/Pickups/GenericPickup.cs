using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(GenericAudioPlayer))]
public class GenericPickup : MonoBehaviour {
	[Space(5f)]
	[Header("Base dependencies")]
	public GenericAudioPlayer genericAudioPlayer;

	[Space(5f)]
	[Header("Base variables")]
	public bool destroyOnPickUp = true;
}
