using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public int speed = 6;
	// Use this for initialization
	void Start () {
        var rigidBody = this.GetComponent<Rigidbody2D>();
        rigidBody.velocity=new Vector2(0,speed);

    }

    // Update is called once per frame
    void Update () {

    }

    public void OnBecameInvisible(){
        Destroy(gameObject);
    }

}
