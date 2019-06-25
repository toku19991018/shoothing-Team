using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    //public GameObject EnemyBullet;//
    public GameObject Explosion;
    float Z_Speed = -0.1f;//
    float intervalTime;

    // Start is called before the first frame update
    void Start()
    {
        intervalTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -1 * Z_Speed);

        Quaternion quat = Quaternion.Euler(0, 180, 0);

        //intervalTime += Time.deltaTime;
        //if(intervalTime >= 0.1f)
        //{
        //    intervalTime = 0.0f;
        //    //Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat);
        //}

    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(this.gameObject);

        }
        if (coll.gameObject.tag == "PlayerBullet")
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(this.gameObject);

        }

    }
}
