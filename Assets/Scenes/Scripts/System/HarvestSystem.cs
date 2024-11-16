using UnityEngine;
using UnityEngine.Tilemaps;

public class HarvestSystem : MonoBehaviour
{
    public Tilemap farmTilemap;
    public TileBase harvestedTile; // Tile ที่ใช้แสดงว่าเก็บเกี่ยวแล้ว

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // ใช้คลิกขวาในการเก็บเกี่ยว
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int gridPosition = farmTilemap.WorldToCell(worldPoint);

            if (farmTilemap.GetTile(gridPosition) == farmTilemap.GetTile(gridPosition)) // ตรวจสอบว่าพืชอยู่ในระยะเติบโตสุดท้าย
            {
                farmTilemap.SetTile(gridPosition, harvestedTile); // เปลี่ยนเป็น Tile หลังการเก็บเกี่ยว
                // เพิ่มโค้ดเก็บผลผลิตไปยัง Inventory ได้
            }
        }
    }
}
