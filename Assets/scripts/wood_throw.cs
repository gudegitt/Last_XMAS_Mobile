using UnityEngine;

public class wood_throw : MonoBehaviour
{
    public static bool lose = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "dog")
            lose = true;
    }
}
