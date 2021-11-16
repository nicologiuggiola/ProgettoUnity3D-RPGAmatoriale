using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    public Transform transform;
    public List<GameObject> drops;
    public float dropForward;
    public float dropUp;
    public int[] table =
    {
        60,
        30,
        10
    };

    public int total;
    public int randomNum;

    private void Start()
    {
        foreach(var item in table)
        {
            total += item;
        }

        randomNum = Random.Range(0, total);

    }

    public void OnDeathDrop()
    {
        for (int i = 0; i < table.Length; i++)
        {
            if (randomNum <= table[i])
            {
                Vector3 position = transform.position;
                Instantiate(drops[i], position, Quaternion.identity);
                return;
            }
            else
            {
                randomNum -= table[i];
            }
        }
    }
}
