using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{

    [SerializeField] GameObject MyPrefab;
    [SerializeField] Transform InitPos;

    float intervalo;

    // Start is called before the first frame update
    void Start()
    {
        intervalo = 1f;
        StartCoroutine("CrearObstaculos");

    }

    IEnumerator CrearObstaculos()
    {
        while (true)
        {
           
            Vector3 instPos = new Vector3(Random.Range(-20f, 20f), 0f, InitPos.position.z);
            Instantiate(MyPrefab, instPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);

        }

    }


}
