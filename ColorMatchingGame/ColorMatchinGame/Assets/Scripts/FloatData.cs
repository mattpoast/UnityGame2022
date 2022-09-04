using UnityEngine;
[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public int value;
    public void UpdateValue(int num)
    {
        value += num;
    }
}
