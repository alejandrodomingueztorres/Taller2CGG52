using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearScript : MonoBehaviour
{
    public GameObject Bullet1;
    public GameObject player;
    private float LastAtack;
    private int Health = 3;

    private void Update()
    {
        if (player == null) return;

        Vector3 direction = player.transform.position - transform.position;
        if (direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

        float distance = Mathf.Abs(player.transform.position.x - transform.position.x);

        if (distance < 1.0f && Time.time > LastAtack + 0.25f)
        {
            Atack();
            LastAtack = Time.time;
        }
       
    }
    private void Atack()
    {
        Vector3 direction;
        if (transform.localScale.x == 1.0f) direction = Vector3.right;
        else direction = Vector3.left;
        GameObject bullet = Instantiate(Bullet1, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<Bullets1Script>().SetDirection(direction);
    }

    public void Hit()
    {
        Health = Health - 1;
        if (Health == 0) Destroy(gameObject);
    }
}