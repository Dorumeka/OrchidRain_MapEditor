using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GenericAudioPlayer : AudioManager {
	[Space(5f)]
	[Header("Dependencies")]
	public AudioType audioType;
	public AudioClip[] clips;

	[Space(5f)]
	[Header("Variables")]
	public float volume = 1f;
	public float maxDistance = 20f;
	public bool non3D = false;
}
