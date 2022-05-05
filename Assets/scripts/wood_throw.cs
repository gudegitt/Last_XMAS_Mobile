using UnityEngine;

public class wood_throw : MonoBehaviour
{
    public static bool lose_dog = false;

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("INININ");
        if (other.gameObject.tag == "dog")
            lose_dog = true;
        Destroy(gameObject, 1);
    }
}
