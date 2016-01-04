using UnityEngine;
using System.Collections;

namespace Escape
{
	public class GameManager : MonoBehaviour 
	{
		public RoomComponent CurRoom = null;
		public static GameManager Instance = null;

		void Awake()
		{
			Instance = this;
		}

		public void GoTo(RoomComponent room)
		{
			if (CurRoom != null)
				CurRoom.Hide ();

			CurRoom = room;
			if (CurRoom != null)
				CurRoom.Show();
		}
	}
}