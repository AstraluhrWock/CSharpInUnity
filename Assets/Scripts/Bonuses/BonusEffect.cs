using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusEffect : MonoBehaviour
{
    private ParticleSystemRenderer _particle;

    // Start is called before the first frame update
    void Start()
    {
        _particle = GetComponent<ParticleSystemRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
