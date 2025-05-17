using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private List<EnemyPattern> patterns;
    private int seed;
    private EnemyPattern currentPattern;

    public void SetSeed(int seed)
    {
        this.seed = seed;
    }

    private void Start()
    {
        currentPattern = patterns[seed % patterns.Count];

        int index = 0;
        for (int i = 0; i < currentPattern.obj.Count; i++)
        {
            GameObject obj = Instantiate(currentPattern.obj[index]);
            Vector2 offset = Random.insideUnitCircle*50;
            obj.transform.position = transform.position + new Vector3(offset.x, 2, offset.y);
            index++;
            if(index>=currentPattern.obj.Count)
            {
                index = 0;
            }
        }
    }
}
