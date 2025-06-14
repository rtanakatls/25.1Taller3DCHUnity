using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private int speed;
    [SerializeField] private int life;
    [SerializeField] private int bullets;

    public int Life { get { return life; }}
    public int Bullets { get {  return bullets; }}
    public int Speed { get {  return speed; }}
}
