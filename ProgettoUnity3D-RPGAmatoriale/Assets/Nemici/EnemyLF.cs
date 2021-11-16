using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLF : MonoBehaviour
{
    public EnemyDrop drop;
    public float lifepoints = 10f;
    public float cur_lifepoints = 0f;
    public bool vivo = true;

    // Start is called before the first frame update
    void Start()
    {
        cur_lifepoints = lifepoints;
        vivo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (cur_lifepoints <= 0)
        {
            vivo = false;
        }

        if (!vivo)
        {
            drop.OnDeathDrop();
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float damage)
    {
        //if (!vivo)
        //{
            //return;
        //}

        //if (cur_lifepoints <= 0)
        //{
            //vivo = false;
        //}

        cur_lifepoints -= damage;
    }
    public void TakeAerialDamage(float damage)
    {
        //if (!vivo)
        //{
            //return;
        //}

        //if (cur_lifepoints <= 0)
        //{
            //vivo = false;
        //}

        cur_lifepoints -= damage;
    }

}
