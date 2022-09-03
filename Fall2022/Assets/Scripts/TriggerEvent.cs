using UnityEngine;
using UnityEngine.Events;
public class TriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerExitEvent;
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}
