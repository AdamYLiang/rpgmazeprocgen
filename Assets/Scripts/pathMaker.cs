using UnityEngine;
using System.Collections;

public class pathMaker : MonoBehaviour {

	private int counter = 0;
	public Transform wall1;
	public Transform wall2;
	bool isGap = false;
	Transform tempFloor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(counter <= 20){

			//Pathmaker
			float randomNumber = Random.Range(0f,1f);
			if(randomNumber < 0.25f){
				transform.Rotate(new Vector3(0, 90, 0));
			}

			if(randomNumber >= 0.25f && randomNumber < 0.50f){
				transform.Rotate(new Vector3(0, -90, 0));
			}

			//Choosing type of wall to make
			randomNumber = Random.Range (0f, 1f);
			if(randomNumber < 0.5f){
				Debug.Log ("Meh memed");
				tempFloor = wall1;
			}

			else{
				Debug.Log ("well memed");
				tempFloor = wall2;
			}

			//Choosing whether to make the wall or not

			randomNumber = Random.Range (0f, 1f);
			if(randomNumber < 0.33f){
				isGap = true;
			}

			else{
				isGap = false;
			}

			if(!isGap){

				if ((transform.position.x <= 12) &&
				   (transform.position.x >= -20) &&
				   (transform.position.z >= -9) &&
				   (transform.position.z <= 18)) {

						Object temp = Instantiate (tempFloor, transform.position, tempFloor.transform.rotation);
						transform.position += transform.forward * 5;
						counter++;
				}

				else{
					transform.position = new Vector3 (-8f, 0.77f, 4f);
				}
			}

			else{
				transform.position += transform.forward * 5;
				counter++;
			}


		}

		else{
			Destroy (this);
		}

	}
}
