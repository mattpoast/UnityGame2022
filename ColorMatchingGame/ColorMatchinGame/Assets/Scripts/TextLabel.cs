using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class TextLabel : MonoBehaviour
{
   private Text label;
   public UnityEvent startEvent;
   private void Start()
   {
      label = GetComponent<Text>();
      startEvent.Invoke();
   }
   public void UpdateLabel(FloatData obj)
   {
      label.text = obj.value.ToString();
   }
   public void UpdateLabel(IntData obj)
   {
      label.text = obj.value.ToString();
   }
}
