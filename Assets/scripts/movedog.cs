using UnityEngine;

public class movedog : MonoBehaviour
{
    public float speed = 10f;
    public float jumpforce = 2f;

    //SpriteRenderer dg;
    Transform dg;
    Rigidbody rbdg;


    void Start()
    {
        //speed = 10f;
        //dg = GetComponent<SpriteRenderer>();
        dg = GetComponent<Transform>();
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f, Space.World);
        if (wood_throw.lose) {
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

            speed = -speed / 2;
            //rbdg.AddForce(new Vector3(jumpforce, jumpforce, 0), ForceMode.Impulse);

        }
    } 
}
