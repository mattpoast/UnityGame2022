using UnityEngine;
public class IntData : ScriptableObject
{
   public int value;

   public void UpdateValue(int num)
   {
      value += num;
   }
}
