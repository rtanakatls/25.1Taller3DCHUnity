using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PatternSettings", menuName = "LevelSettings/PatternSettings")]
public class PatternSettings : ScriptableObject
{
    [SerializeField] private List<LevelPattern> patterns;

    public List<LevelPattern> LevelPatterns { get { return patterns; } }

}
