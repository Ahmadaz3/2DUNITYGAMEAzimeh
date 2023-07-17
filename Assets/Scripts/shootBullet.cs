using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBullet : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    private bool canShoot = true;
    void Start()
    {

    }

    // Update is called once per frame


    void Update()
    {
        if (Input.GetMouseButton(0) && canShoot)
        {
            StartCoroutine(ShootBullet());
        }
    }
    IEnumerator ShootBullet()
    //in order to control shooting
    {
        canShoot = false;
        GameObject.Instantiate(bullet, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        canShoot = true;
    }
}
