using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class ColliderTrigger : MonoBehaviour
{
     [SerializeField] UnityEvent m_event;

    private void Start()
    {
        
    }

    private void Awake()
    {
        if (m_event == null) m_event = new UnityEvent();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"{name} hit {other.gameObject.name}");
            m_event.Invoke();
        }
    }
}
