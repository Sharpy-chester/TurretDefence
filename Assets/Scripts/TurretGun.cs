using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGun : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform bulletSpawner;
    Vector2 target;
    Vector2 direction;
    public float shotCooldown = 1f;
    float timer = 1;

    void Update()
    {
        //Vector3 upAxis = new Vector3(0, 0, 1);
        //Vector3 mouseScreenPosition = Input.mousePosition;
        //mouseScreenPosition.z = transform.position.z;
        //Vector3 mouseWorldSpace = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        //transform.LookAt(mouseWorldSpace, upAxis);
        //transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z);
        var mouse = Input.mousePosition;
        var screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        var offset = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);
        var angle = Mathf.Atan2(offset.x, offset.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, -angle);
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Mouse0) && timer > shotCooldown)
        {
            Shooting();
            timer = 0;
        }
        
    }

    void Shooting()
    {
        Vector3 test = transform.eulerAngles;
        test = new Vector3(target.x, target.y, 0);
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawner.transform.position, this.transform.rotation);
        bullet.transform.SetParent(null);
        bullet.transform.localScale = new Vector3(1, 1, 1);
    }
}
