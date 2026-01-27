using UnityEngine;

public class LaneManger : MonoBehaviour
{
 [SerializeField]
 private Lane[] lanes;
 public Lane GetLane(int index)
    {
        return lanes[index];
    }
}
