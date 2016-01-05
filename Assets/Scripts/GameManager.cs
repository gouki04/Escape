using UnityEngine;
using System.Collections;

namespace Escape
{
	public class GameManager : MonoBehaviour 
	{
		public RoomComponent CurRoom = null;
		public static GameManager Instance = null;
		public PlayMakerFSM FSM = null;

		void Awake()
		{
			Instance = this;
			FSM = GetComponent<PlayMakerFSM> ();
		}

		public void GoTo(RoomComponent room)
		{
			if (CurRoom != null)
				CurRoom.Hide ();

			CurRoom = room;
			if (CurRoom != null)
				CurRoom.Show();
		}

		public void OnClickTranferBtn(tk2dUIItem item)
		{
			FireEvent (item.triggerEventName);
		}

		public void FireEvent(string event_name)
		{
			FSM.SendEvent (event_name);
		}
	}
}