using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlare : MonoBehaviour
{

    [SerializeField] Rigidbody flare;
    [SerializeField] float strength = 2f;
    [MinMax(-3, 3, MaxLimit = 5, MinLimit = -5, ShowDebugValues = true)]
    [SerializeField] Vector2 torque;
    [SerializeField] float timeOut_s;
    float chronalAcumulator = Mathf.Infinity;

    bool played = true;

    // Update is called once per frame
    void Update()
    {
        if (WellPlayer.Instance.height > -65f) return;

        if (chronalAcumulator > timeOut_s && !played)
        {
            played = true;
            GetComponent<AudioSource>().Play();
        }

        // TODO: Use input manager
        if (
            (Input.GetKeyDown("q") || Input.GetMouseButtonDown(0)) &&
            chronalAcumulator > timeOut_s
            ) Throw();

        chronalAcumulator += Time.deltaTime;

    }

    void Throw()
    {
        var theFlare = Instantiate(flare, transform.position, transform.rotation);
        theFlare.gameObject.transform.parent = Assets.Instance.transform;
        theFlare.AddForce(transform.forward * strength);
        theFlare.AddTorque(Random.onUnitSphere * Random.Range(torque.x, torque.y));
        Destroy(theFlare.gameObject, 10f);
        chronalAcumulator = 0;
        played = false;
    }
}
