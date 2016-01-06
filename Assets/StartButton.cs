using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour 
{
	public void EnterGame()
	{
		Application.LoadLevel ("main");
	}
}
