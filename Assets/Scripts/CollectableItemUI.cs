using UnityEngine;
using UnityEngine.UI;

public class CollectableItemUI : MonoBehaviour
{
    [SerializeField] private CollectableData data;
    public CollectableData Data { get { return data; } }

    public void SetUp(CollectableData data)
    {
        this.data = data;
        GetComponent<Image>().sprite = data.UISprite;
    }

}
