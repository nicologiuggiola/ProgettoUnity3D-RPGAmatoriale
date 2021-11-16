using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public PlayerStatPrefab Player;
    public float speed = 20;
    public int damage;
    public float despawnClock = 5f;

    private float despawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        despawnTimer = despawnClock;
    }

    // Update is called once per frame
    void Update()
    {
        //damage = (Player.charStats.Forza / 6f);
        transform.position += transform.forward * speed * Time.deltaTime;

        despawnTimer -= Time.deltaTime;

        if (despawnTimer <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider enemy)
    {
        enemy.gameObject.GetComponent<EnemyLF>().TakeAerialDamage(damage);
        Destroy(gameObject);
    }
}
