using System.Collections;
using UnityEngine;

public class woodHit : MonoBehaviour
{
    public static bool lose_dog; // = false;
    //private float _timeback = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_waitb());
    }

    // Update is called once per frame
    void Update()
    {
        //lose_dog = false;
        Debug.Log(lose_dog);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fireplace")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "dog")
        {
            lose_dog = true;
            Destroy(gameObject);
            /*if (lose_dog == true)
            {
                Invoke("lose_dog = false", _timeback);
                    //lose_dog = false;
                
            }*/
        }
    }
    private IEnumerator _waitb()
    {
        if (woodHit.lose_dog == true)
        {
            yield return new WaitForSeconds(3);
            woodHit.lose_dog = false;
        }
    }
}
