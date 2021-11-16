using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowThree : MonoBehaviour
{
    public NewThree Player;
    public float speed = 20;
    public float damage = 0;
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
        damage = (Player.charThreeStats.Forza / 6f);
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
