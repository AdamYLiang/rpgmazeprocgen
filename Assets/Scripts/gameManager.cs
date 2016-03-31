using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gameManager : MonoBehaviour {

	public Transform slime;
	public Transform hero;
	public static List<Transform> listOfSlimes = new List<Transform>();
	public static List<Transform> listOfHeroes = new List<Transform>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray makerRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit makerRayInfo = new RaycastHit();


		if(Input.GetMouseButtonDown(0) && Physics.Raycast(makerRay, out makerRayInfo, 1000f)){
			Transform temp = (Transform)Instantiate(hero, makerRayInfo.point, Quaternion.identity);
			listOfHeroes.Add(temp);
		}

		if(Input.GetMouseButtonDown(1) && Physics.Raycast(makerRay, out makerRayInfo, 1000f)){
			Transform temp = (Transform)Instantiate(slime, makerRayInfo.point, Quaternion.identity);
			listOfSlimes.Add(temp);
		}
	}
}
