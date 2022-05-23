using UnityEngine;
using UnityEngine.Events;

class PlayerTrigger : MonoBehaviour, Trigger
{
    public UnityEvent<Trigger> onTriggered;
    public UnityEvent<Trigger> onAfterEvent;

    void OnTriggerEnter(Collider other)
    {
        Triggered();
    }

    public void Triggered() 
    {
        onTriggered.Invoke(this);
    }

    public void AfterEvent()
    {
        onAfterEvent.Invoke(this);
    }
}
