using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent m_event;

    private void Awake()
    {
        if (m_event == null) m_event = new UnityEvent();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{name} hit {other.gameObject.name}");
        if (other.CompareTag("Player")) 
            m_event.Invoke();
    }
}
