using System;
using UnityEngine;
using UnityEngine.Events;

namespace Components
{
    public class OnCollisionComponent : MonoBehaviour
    {
        [SerializeField] private string _tag;
        [SerializeField] private UnityEvent _event;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag(_tag))
            {
                _event.Invoke();
            }
        }
    }
}