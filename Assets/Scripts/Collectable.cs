 using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private CollectableData collectableData;

    public CollectableData CollectableData { get { return collectableData; } }
}
