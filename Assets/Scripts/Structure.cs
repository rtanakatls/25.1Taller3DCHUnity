using UnityEngine;

public class Structure : MonoBehaviour
{
    [SerializeField] private CollectableData data;
    public CollectableData Data { get { return data; } }
}
