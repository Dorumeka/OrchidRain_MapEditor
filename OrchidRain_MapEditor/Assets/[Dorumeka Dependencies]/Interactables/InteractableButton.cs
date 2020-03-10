using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableButton : MonoBehaviour {
	[Space(5f)]
	[Header("Dependencies")]
	public ButtonSoundPlayer buttonSoundPlayer;
	public Animator animator;

	void PlayerInteract () {
		buttonSoundPlayer.Play();
		animator.SetTrigger("Press");
	}
}
