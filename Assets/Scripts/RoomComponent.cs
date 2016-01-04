using UnityEngine;
using System.Collections;

namespace Escape
{
	public class RoomComponent : MonoBehaviour 
	{
		public void Show()
		{
			gameObject.SetActive (true);
		}

		public void Hide()
		{
			gameObject.SetActive (false);
		}
	}
}