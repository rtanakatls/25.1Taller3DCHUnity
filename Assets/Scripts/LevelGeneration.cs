using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    [SerializeField] private PatternSettings patternSettings;

    [SerializeField] private int seed;
    private LevelPattern currentPattern;

    private void Awake()
    {
        
        seed = Random.Range(0, 10000);
        currentPattern = patternSettings.LevelPatterns[seed % patternSettings.LevelPatterns.Count];

        int index = 0;
        for (int i = 0; i <= 9; i++)
        {
            GameObject obj = Instantiate(currentPattern.obj[index]);
            obj.transform.position = Vector3.forward * i * 100;
            obj.GetComponent<EnemyGenerator>().SetSeed(seed);
            index++;
            if(index>= currentPattern.obj.Count)
            {
                index = 0;
            }
        }

    }
}
