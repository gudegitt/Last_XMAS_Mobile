
using UnityEngine;

public class woodThrow : MonoBehaviour {
public GameObject woodKick;
private bool touch = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
        touch = true;
        Debug.Log("Pressed primary button.");
        }
    }
    void FixedUpdate()
    {
          if(touch == true)
          {
          Transform woodKickMove = Instantiate(woodKick.transform, gameObject.transform.position, Quaternion.identity);
          woodKickMove.GetComponent<Rigidbody>().AddForce(transform.forward *500);
          touch = false;
          }
    }
}
