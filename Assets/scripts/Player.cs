using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {




	private float interval =  0.3f;
	private Transform logs;


	public GameObject logObj;	
	public Text logText;



	void Awake(){


	

		logs = GameObject.Find ("Logs").transform;
	}
	// Use this for initialization
	void Start () {

		pushOnTexts ("1");
		pushOnTexts ("hehllo");
		pushOnTexts ("hehllo");
		pushOnTexts ("hehllo");
		pushOnTexts ("hehllo");
		pushOnTexts ("hehllo");
		pushOnTexts ("hehllo");
		pushOnTexts ("hehllo");
		pushOnTexts ("hehllo");
		pushOnTexts ("hehllo");
		pushOnTexts ("hehllo");
		pushOnTexts ("hehllo");
		pushOnTexts ("hehllo");
		pushOnTexts ("hehllo");
		pushOnTexts ("kimchi");
		pushOnTexts ("man");
			
	}


	IEnumerator Attacking(){
		while (true) {
			yield return new WaitForSeconds (interval);



		}
		
	
	}



	private Stack<GameObject> texts = new Stack<GameObject>();
	public int yPos = 32;
	void pushOnTexts(string pushString){




		GameObject a = Instantiate (logObj,logs.transform.position, Quaternion.identity,logs.transform) as GameObject;
		a.GetComponent<Text> ().text = pushString;

		if (texts.Count >= 10) {
			Debug.Log ("이때 안찍 위"+texts.Count);
			 GameObject del = texts.Pop () as GameObject;
			 
			Destroy (del);



			texts.Push ( a as GameObject );
		} else {
			Debug.Log ("이때 아래"+texts.Count);
			texts.Push ( a as GameObject );			
		}


		int i = 1;
		foreach (GameObject dic in texts) {
			dic.GetComponent<Transform> ().localPosition = new Vector2 (0, yPos * i);  
			i++;
		}
			
	}
}
