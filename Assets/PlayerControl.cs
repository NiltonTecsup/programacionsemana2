using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour{
   
	private Transform _compTransform;
	private SpriteRenderer _compSpriteRenderer;
	public float speed;
	public int direction;
    	// Start is called before the first frame update

	void Awake(){
		_compTransform = GetComponent<Transform>();
		_compSpriteRenderer = GetComponent<SpriteRenderer>();
    	}

    	void Start()
    	{   
	
	
    	}

    	// Update is called once per frame
    	void Update()
    	{
		_compTransform.position = new Vector2(_compTransform.position.x + speed * direction * Time.deltaTime,0);
		if(_compTransform.position.x > 8.2f){
			direction = -1;
			_compSpriteRenderer.flipX = true;
		}
		if(_compTransform.position.x < -8.2f){
			direction = 1;
			_compSpriteRenderer.flipX = false;
		}
    	}
}