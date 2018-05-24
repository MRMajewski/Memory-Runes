using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public bool Active = true;
    public Sprite frontFace;


	void Start () {
        transform.rotation = GetTargetRotation();

        var frontObject = transform.Find("front");
        var spriteRenderer = frontObject.transform.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = frontFace;

	}
	
	// Update is called once per frame
	void Update () {

        var targetRotation = GetTargetRotation();
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 5);
		
	}

    Quaternion GetTargetRotation()
    {
        var rotation = Active ? Vector3.zero : (Vector3.up*180f);
        return Quaternion.Euler(rotation);
    }
}
