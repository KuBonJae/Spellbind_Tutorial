using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEffectScript : MonoBehaviour
{
    [SerializeField]
    GameObject particlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(particlePrefab, gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
