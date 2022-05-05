using UnityEngine;

public class movedog : MonoBehaviour
{
    public float speed = 10f;
    public float airspeed = 20f;
    //public float jumpforce = 2f;

    //SpriteRenderer dg;
    public Transform wood_lose;
    Transform dg;
    Material colordg;
    //Rigidbody rbdg;


    void Start()
    {
        //speed = 10f;
        //dg = GetComponent<SpriteRenderer>();
        dg = GetComponent<Transform>();
        colordg = GetComponent<Material>();
        //rbdg = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //transform.Translate(speed * Time.deltaTime, 0f, 0f, Space.World);
        if (wood_throw.lose_dog == false) {
            transform.Translate(speed * Time.deltaTime, 0f, 0f, Space.World);
            if (transform.position.x < -6.62f)
            {
                speed = -speed;
                dg.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, transform.rotation.eulerAngles.z);

            }
            if (transform.position.x > 5.46f)
            {
                speed = -speed;
                dg.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, transform.rotation.eulerAngles.z);
            }
        }
        else if (wood_throw.lose_dog == true) {
            transform.position = Vector3.MoveTowards(transform.position, wood_lose.position, Time.deltaTime * airspeed);
            ;
            Destroy(gameObject, 1);
            if (transform.position.x < -6.62f)
            {
                airspeed = -airspeed;
                dg.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, transform.rotation.eulerAngles.z);
            }
            if (transform.position.x > 5.46f)
            {
                airspeed = -airspeed;
                dg.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, transform.rotation.eulerAngles.z);
            }
            //speed = 100;
            //rbdg.AddForce(new Vector3(0f, jumpforce, 0f), ForceMode.Impulse);
            //transform.position = Vector3.MoveTowards(transform.position, wood_lose.position, Time.deltaTime * speed);
            //transform.Translate(0f, speed * Time.deltaTime, 0f, Space.World);
        }
    } 
}
