using UnityEngine;
using UnityEngine.Tilemaps;

public class PlantingSystem : MonoBehaviour
{
    public Tilemap farmTilemap;
    public TileBase seedTile; // Tile สำหรับเมล็ดพันธุ์

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int gridPosition = farmTilemap.WorldToCell(worldPoint);

            // ตรวจสอบว่าผู้เล่นสามารถปลูกได้หรือไม่
            if (farmTilemap.HasTile(gridPosition))
            {
                farmTilemap.SetTile(gridPosition, seedTile);
            }
        }
    }
}
