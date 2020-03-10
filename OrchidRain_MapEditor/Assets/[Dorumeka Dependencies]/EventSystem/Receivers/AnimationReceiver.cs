using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationReceiver : EventReceiver {
	[Space(5f)]
	[Header("Variables")]
	public string animatorBoolName;
	private Animator _animator;

	void Start () {
		_animator = GetComponentInChildren<Animator>();
	}

	public override void TriggerReceiver (EventInfo eventInfo) {
		base.TriggerReceiver(eventInfo);
		if (_animator) {
			bool b = _animator.GetBool(animatorBoolName);
			_animator.SetBool(animatorBoolName, !b);
		}
	}
}
