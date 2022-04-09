using System.Collections;
using UnityEngine;

public class spawndog : MonoBehaviour
{
    public GameObject dog;
    void Start()
    {

        StartCoroutine(Spawn());
                
    }
    IEnumerator Spawn ()
    {
        while (true) {
            Instantiate(dog, new Vector3(-7.27f, -1.398f, -8.65f), Quaternion.identity);
            yield return new WaitForSeconds(6f);
        }
    }
  
}
