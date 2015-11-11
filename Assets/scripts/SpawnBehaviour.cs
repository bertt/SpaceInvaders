using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    public MonoBehaviour enemyprefab;

    public int SpawnTime = 2;
	void Start () {
        InvokeRepeating("addEnemy",SpawnTime,SpawnTime);
	}


    public void addEnemy()
    {
        var renderer1= this.GetComponent<Renderer>();

        var x1 = transform.position.x - renderer1.bounds.size.x / 2;
        var x2 = transform.position.x + renderer1.bounds.size.x / 2;

        var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(enemyprefab, spawnPoint, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
