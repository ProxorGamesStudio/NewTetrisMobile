using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class GameSettings : EditorWindow {

	public CenterGame center;

	[MenuItem("Game/Center Game")]
	public static void Init()
	{
		GameSettings window = (GameSettings)EditorWindow.GetWindow(typeof(GameSettings));
		window.title = "Game center";
		window.autoRepaintOnSceneChange = true;
		
	}

	void OnGUI()
	{
		center = GameObject.FindObjectOfType(typeof(CenterGame)) as CenterGame;
		if(center != null)
		{

			GUILayout.BeginVertical(GUI.skin.box);
			GUILayout.BeginHorizontal(GUI.skin.box);
			GUILayout.Label("Общая скорость предметов:");
			GUILayout.Space(2);
			center.speed = EditorGUILayout.FloatField((float)center.speed);
			GUILayout.EndHorizontal();
			GUILayout.EndVertical();

		}
		else
		{
			GUI.color = Color.red;
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			GUILayout.Label("На сцене нет требуемых компонентов для корректной работы!", GUI.skin.label);
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
			GUI.color = Color.white;
	}
	}
}
