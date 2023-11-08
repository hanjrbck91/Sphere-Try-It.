using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        Invoke("ShootBullet", 2);
    }
    void ShootBullet()
    {
        var newBullet = Instantiate(bullet);
        newBullet.transform.position = new Vector3(0, 40, 0);
        Destroy(newBullet, 5);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
        }
    }
}
