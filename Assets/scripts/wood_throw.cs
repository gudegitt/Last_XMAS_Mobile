using UnityEngine;
using System.Collections;
using System.Linq;

public class wood_throw : MonoBehaviour
{
    public GameObject[] poleno;
  //  private bool thrown = false;
    private GameObject polenoClone;
    private Vector3 polenoPos = new Vector3 (0, 0, -12);
    public static bool lose = false;
    private static bool thrown = false;
    private static bool triggerWood = false;
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "dog")
        {
            lose = true;
        }
    }

    private void thrownWood()
    {
      if (thrown == true)
      {
         polenoClone = Instantiate(poleno[0],polenoPos + Vector3.forward, Quaternion.identity) as GameObject;
         polenoClone.transform.localScale = new Vector3 (0.25f, 0.25f, 0.25f);

         polenoClone.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
      }
    }

    void thrownWaiting()
    {
      thrownWood();
    }

    void Update()
   {
       if (Input.GetMouseButtonDown(0))
        {
          thrown = true;
        }
    }
    void FixedUpdate()
    {
        thrownWaiting();
      if (thrown == true && triggerWood == true)
        {
          Destroy(polenoClone);
          thrown = false;
          triggerWood = false;
       }
   }
}
