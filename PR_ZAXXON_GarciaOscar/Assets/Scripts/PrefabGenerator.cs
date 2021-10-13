using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{

    [SerializeField] GameObject MyPrefab;
    [SerializeField] GameObject MyPrefabY;
    [SerializeField] Transform InitPos;
    [SerializeField] Transform InitPosY;

    float intervalo;

    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.5f;
        StartCoroutine("CrearObstaculos");
        StartCoroutine("CrearObstaculosY");

    }

    IEnumerator CrearObstaculos()
    {
        while (true)
        {
           
            Vector3 instPos = new Vector3(Random.Range(-40f, 40f), 0f, InitPos.position.z);
            Instantiate(MyPrefab, instPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);

        }


    }

    IEnumerator CrearObstaculosY()
    {

        while (true)
        {

            Vector3 instPos = new Vector3(Random.Range(-40f, 40f), Random.Range(10f, 40f), InitPosY.position.y);
            Instantiate(MyPrefabY, instPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);

        }


    }

}
