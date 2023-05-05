using UnityEngine;
using TMPro;

[CreateAssetMenu(menuName = "Enemy")]
public class EnemyData : ScriptableObject
{
	[Header("Enemy Information")]
	public string Name;
	public string DeathScreenMessage;
    public TMP_FontAsset DeathScreenFont;
	[Header("Enemy Danger >:3")]
	public float Speed;
	//[Range(0,1)] public float Rarity;
	public float DetectionRange;
    public bool AlwaysChasePlayer;
}