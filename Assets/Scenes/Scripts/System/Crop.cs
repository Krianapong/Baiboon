using UnityEngine;
using UnityEngine.Tilemaps;

public class Crop : MonoBehaviour
{
    public Tilemap farmTilemap;
    public TileBase[] growthStages; // เก็บ Tile แต่ละช่วงของการเติบโต
    public float timeToGrow = 5f; // ระยะเวลาในการเปลี่ยนสู่การเติบโตขั้นถัดไป
    private int currentStage = 0;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeToGrow && currentStage < growthStages.Length - 1)
        {
            timer = 0f;
            currentStage++;
            UpdateCropTile();
        }
    }

    void UpdateCropTile()
    {
        Vector3Int gridPosition = farmTilemap.WorldToCell(transform.position);
        farmTilemap.SetTile(gridPosition, growthStages[currentStage]);
    }
}
