using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMov : MonoBehaviour
{

    [SerializeField] float speed = 100f;

    // Start is called before the first frame update
    void Update()
    {

        transform.Translate(Vector3.back * Time.deltaTime * speed);

        float posZ = transform.position.z;

        if (posZ < -60)
        {
            Destroy(gameObject);
        }

    }

    private void Start()
    {

        speed = 50f;


    }



}
