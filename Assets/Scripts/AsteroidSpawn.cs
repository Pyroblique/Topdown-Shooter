using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public Gravity asteroidPrefab;
    bool spawning = true;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Asteroids());
    }

    IEnumerator Asteroids()
    {
        // To repeatedly spawn loads of obstacles
        while (spawning)
        {
            Gravity clone = (Gravity)Instantiate(asteroidPrefab, new Vector3(-0.73f, 5.33f, 7.68f), transform.rotation);
            yield return new WaitForSeconds(0.2f);

            Gravity clone1 = (Gravity)Instantiate(asteroidPrefab, new Vector3(5f, 5.33f, 7.68f), transform.rotation);
            yield return new WaitForSeconds(0.2f);

            Gravity clone2 = (Gravity)Instantiate(asteroidPrefab, new Vector3(-2f, 5.33f, 7.68f), transform.rotation);
            yield return new WaitForSeconds(0.2f);

            Gravity clone3 = (Gravity)Instantiate(asteroidPrefab, new Vector3(4.2f, 5.33f, 7.68f), transform.rotation);
            yield return new WaitForSeconds(0.2f);

            Gravity clone4 = (Gravity)Instantiate(asteroidPrefab, new Vector3(-6f, 5.33f, 7.68f), transform.rotation);
            yield return new WaitForSeconds(0.2f);

            Gravity clone5 = (Gravity)Instantiate(asteroidPrefab, new Vector3(1.3f, 5.33f, 7.68f), transform.rotation);
            yield return new WaitForSeconds(0.2f);

            Gravity clone6 = (Gravity)Instantiate(asteroidPrefab, new Vector3(-4f, 5.33f, 7.68f), transform.rotation);
            yield return new WaitForSeconds(0.2f);

            Gravity clone7 = (Gravity)Instantiate(asteroidPrefab, new Vector3(6.2f, 5.33f, 7.68f), transform.rotation);
            yield return new WaitForSeconds(0.2f);
        }
    }


   
}
