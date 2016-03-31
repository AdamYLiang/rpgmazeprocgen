using UnityEngine;
using System.Collections;

public class mouse : MonoBehaviour {
 
	AudioSource myAudio;

	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		for(int i = 0; i < gameManager.listOfHeroes.Count; i++){
			
			Vector3 directionToCat = gameManager.listOfHeroes[i].position - transform.position;
			float angle = Vector3.Angle(transform.forward, directionToCat);

			if(angle < 180){
				Ray mouseRay = new Ray(transform.position, directionToCat);
				RaycastHit mouseRayHitInfo = new RaycastHit();
				//Debug.DrawRay(transform.position, directionToCat * 1000f, Color.yellow);

				if(Physics.Raycast(mouseRay, out mouseRayHitInfo, 4f)){
					if(mouseRayHitInfo.collider.tag == "Cat"){
						myAudio.PlayOneShot (myAudio.clip, 0.5f);
						//Debug.Log("ggwp");
						GetComponent<Rigidbody>().AddForce(-directionToCat.normalized * 1000f);
					}
				}
			}
		}
	}

	void OnDestroy(){
		gameManager.listOfSlimes.Remove(this.transform);
	}
}
