using System;
using UnityEngine;

[Serializable]
public class CollectableData
{
    [SerializeField] private Sprite uiSprite;
    [SerializeField] private string collectableName;

    public Sprite UISprite { get { return uiSprite; } }
    public string CollectableName { get { return collectableName; } }

    public CollectableData(Sprite uiSprite, string collectableName)
    {
        this.uiSprite = uiSprite;
        this.collectableName = collectableName;
    }
}
