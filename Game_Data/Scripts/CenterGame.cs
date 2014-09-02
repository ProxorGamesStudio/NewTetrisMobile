using UnityEngine;
using System.Collections;

public class CenterGame : MonoBehaviour {
	public float speed;
	public bool CanSpawn;
	public GameObject[] Objects;
	public Texture2D TextureOfControl;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(CanSpawn)
		{
			Instantiate(Objects[Random.Range(0, Objects.Length)], transform.position, transform.rotation);
			CanSpawn = false;
		}
	}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Screen.width/13, Screen.height/2, 100, 100), TextureOfControl);
		GUI.DrawTexture(new Rect(Screen.width - Screen.width/13, Screen.height/2, -100, 100), TextureOfControl);
	}
}
