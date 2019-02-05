using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject spawn;
    public GameObject spawnbad;
    float nextSpawn = 1f;
    public float spawnRateGood = 2f;
    public float spawnRateBad = 2f;
    Vector2 whereToSpawn;
    float randX;
    float timer;


    // Update is called once per frame
    void Update ()
    {
        SpawnGoodApple();
        SpawnBadApple();
   
    }

    private void SpawnGoodApple()
    {
        timer = timer + Time.deltaTime;
        // timer += Time.deltaTime


        if (timer > spawnRateGood)
        {
            nextSpawn = Time.deltaTime + spawnRateGood;
            randX = Random.Range(-8f, 8f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(spawn, whereToSpawn, Quaternion.identity);
            timer = 0f;
        }
    }

    private void SpawnBadApple()
    {
        timer = timer + Time.deltaTime;
        // timer += Time.deltaTime


        if (timer > spawnRateBad)
        {
 
            randX = Random.Range(-8f, 8f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(spawnbad, whereToSpawn, Quaternion.identity);
            timer = 0f;
        }
    }
}
