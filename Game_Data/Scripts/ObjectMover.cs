using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class ObjectMover : MonoBehaviour {
	public float speed;
	public CenterGame center;
	public bool MoveLeft, MoveRight;
	// Use this for initialization
	void Start () {
		center = GameObject.FindObjectOfType(typeof(CenterGame)) as CenterGame;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{

	}
}
