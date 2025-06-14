using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private List<CollectableData> collectables;

    private GameObject currentObject;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentObject != null && currentObject.GetComponent<Collectable>())
        {
            CollectableData data = currentObject.GetComponent<Collectable>().CollectableData;
            CollectableData newData = new CollectableData(data.UISprite, data.CollectableName);
            collectables.Add(newData);
            CollectablesController.Instance.Add(newData);
            Destroy(currentObject);
            currentObject = null;
        }

        if (Input.GetKeyDown(KeyCode.E) && currentObject != null && currentObject.GetComponent<Structure>())
        {
            CollectableData currentData = null;
            foreach (CollectableData data in collectables)
            {
                if (data.CollectableName == currentObject.GetComponent<Structure>().Data.CollectableName)
                {
                    currentData = data;
                }
            }
            if (currentData != null)
            {
                CollectablesController.Instance.Remove(currentData);
                collectables.Remove(currentData);
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Collectable"))
        {
            currentObject= collision.gameObject;
        }
        if (collision.gameObject.CompareTag("Structure"))
        {
            currentObject = collision.gameObject;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            currentObject = null;
        }
        if (collision.gameObject.CompareTag("Structure"))
        {
            currentObject = null;
        }
    }

}
