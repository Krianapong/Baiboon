using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // ตรวจสอบว่าชนกับวัตถุที่เราต้องการให้เปลี่ยน Scene หรือไม่
        if (other.CompareTag("SceneChanger"))
        {
            // เปลี่ยนไปยัง Scene 2 (ใช้ชื่อ Scene ที่ต้องการ หรือ Index ของ Scene ใน Build Settings)
            SceneManager.LoadScene("City"); // หรือใช้ SceneManager.LoadScene(1) หาก SecondScene อยู่ในตำแหน่งที่ 1 ใน Build Settings
        }
    }
}
