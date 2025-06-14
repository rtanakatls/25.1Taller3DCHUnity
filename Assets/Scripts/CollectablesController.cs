using System.Collections.Generic;
using UnityEngine;

public class CollectablesController : MonoBehaviour
{
    private static CollectablesController instance;

    public static CollectablesController Instance {  get { return instance; } }

    [SerializeField] private Transform container;
    [SerializeField] private GameObject prefab;
    private List<CollectableItemUI> collectables;

    private void Awake()
    {
        instance = this;
        collectables=new List<CollectableItemUI>();
    }

    public void Add(CollectableData data)
    {
        GameObject obj = Instantiate(prefab, container);
        obj.GetComponent<CollectableItemUI>().SetUp(data);
        collectables.Add(obj.GetComponent<CollectableItemUI>());
    }

    public void Remove(CollectableData data)
    {
        CollectableItemUI collectableItem = null;
        foreach(CollectableItemUI collectable in collectables )
        {
            if(collectable.Data==data)
            {
                collectableItem = collectable;
            }
        }

        if(collectableItem!=null)
        {
            collectables.Remove(collectableItem);
            Destroy(collectableItem.gameObject);
        }

    }

}
