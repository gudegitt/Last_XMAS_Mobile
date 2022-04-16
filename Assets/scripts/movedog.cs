using UnityEngine;

public class movedog : MonoBehaviour
{
    public float speed = 10f;


    //SpriteRenderer dg;
    Transform dg;


    void Start()
    {
        //speed = 10f;
        //dg = GetComponent<SpriteRenderer>();
        dg = GetComponent<Transform>();
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f, Space.World);
        if (!wood_throw.lose) {
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
        else {

            speed = 0;

        }
    } 
}
