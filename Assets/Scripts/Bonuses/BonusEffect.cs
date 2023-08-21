using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusEffect : MonoBehaviour
{
    private ParticleSystemRenderer _particle;

    void Start()
    {
        _particle = GetComponent<ParticleSystemRenderer>();
    }

}
