using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed;

    [Range(0, 100)]
    public float maxTravelDistance;
    Vector2 initialPosition;
    Turret turret;
    Rigidbody2D rb;
    void Start()
    {
        turret = GetComponent<Turret>();
        initialPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed;


    }
    void Update()
    {
        //Turret turret = GetComponent<Turret>();
        //Destroy object if out of sight
        if (maxTravelDistance <= Vector2.Distance(initialPosition, transform.position))
        {
            Destroy(gameObject);

        }
    }
    ///<summery>
    ///Destroy bullet once hits player
    ///</summery>
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player is hit");
            Destroy(gameObject);
        }
    }




}
