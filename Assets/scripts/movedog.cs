using UnityEngine;

public class movedog : MonoBehaviour
{
    public float speed = 10f;
    public float _airspeed = 20f;
    //private float _timeback = 3f;


    //SpriteRenderer dg;
    Transform dg;
    public Transform _wood_lose;


    void Start()
    {
        //speed = 10f;
        //dg = GetComponent<SpriteRenderer>();
        dg = GetComponent<Transform>();
    }

   

    void Update()
    {
            if (woodHit.lose_dog == false) {
            transform.position = new Vector3(transform.position.x, -1.424f, -8.742f);
            transform.Translate(speed * Time.deltaTime, 0f, 0f, Space.World);
            if (transform.position.x < -6.62f)
            {
                speed = -speed;
                dg.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, transform.rotation.eulerAngles.z);

            }
            if (transform.position.x > 5.46f)
            {
                speed = -speed;
                dg.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - 180, transform.rotation.eulerAngles.z);
            }
        }
            else if (woodHit.lose_dog == true) {
            transform.position = Vector3.MoveTowards(transform.position, _wood_lose.position, Time.deltaTime * _airspeed);
            //Destroy(gameObject, 1);
            if (transform.position.x < -6.62f)
            {
                _airspeed = -_airspeed;
                dg.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, transform.rotation.eulerAngles.z);

            }
            if (transform.position.x > 5.46f)
            {
                _airspeed = -_airspeed;
                dg.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - 180, transform.rotation.eulerAngles.z);
            }
            //woodHit.lose_dog = false;
            

        }

    }
}
