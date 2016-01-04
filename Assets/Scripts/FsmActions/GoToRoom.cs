using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Escape")]
	[Tooltip("Go to a room.")]
	public class GoToRoom : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(Escape.RoomComponent))]
		[Tooltip("The destination room.")]
		public FsmOwnerDefault gameObject;

		public override void Reset ()
		{
			gameObject = null;
		}

		public override void OnEnter ()
		{
			var go = Fsm.GetOwnerDefaultTarget(gameObject);
			if (go == null)
				return;

			var room = go.GetComponent<Escape.RoomComponent> ();
			if (room == null)
				return;

			Escape.GameManager.Instance.GoTo (room);
			Finish();
		}
	}
}