using System;
using UnityEngine;
using UnityEngine.Events;

namespace Components
{
    public class OnCollisionEnterComponent : MonoBehaviour
    {
        [SerializeField] private string _tag;
        [SerializeField] private UnityEvent _event;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == _tag)
            {
                _event.Invoke();
            }
        }
    }
}