using UnityEngine;

public class SpaceShipBehaviour : MonoBehaviour
{
    public MonoBehaviour bulletprefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var rigidBody = this.GetComponent<Rigidbody2D>();
	    rigidBody.velocity = new Vector2(Input.GetAxis("Horizontal")*10,0);


	    if (Input.GetKeyDown("space"))
	    {
	        Instantiate(bulletprefab, this.transform.localPosition, Quaternion.identity);

	    }
	}
}
