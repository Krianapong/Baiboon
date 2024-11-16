using UnityEngine;
using System.IO;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // ความเร็วในการเคลื่อนที่ของ Player
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        // โหลดค่า moveSpeed จากไฟล์ JSON
        LoadSettings();

        // ตั้งค่า Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    void Update()
    {
        // รับค่าการกดปุ่มแนวนอนและแนวตั้ง
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // เคลื่อนที่ Player ด้วย Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    // ฟังก์ชันสำหรับโหลดค่า moveSpeed จากไฟล์ JSON
    private void LoadSettings()
    {
        string path = Application.streamingAssetsPath + "/PlayerSettings.json";

        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            PlayerSettings settings = JsonUtility.FromJson<PlayerSettings>(jsonData);

            // ตั้งค่า moveSpeed ตามค่าที่ได้จาก JSON
            moveSpeed = settings.moveSpeed;
            Debug.Log("Loaded moveSpeed from JSON: " + moveSpeed);
        }
        else
        {
            Debug.LogError("Cannot find PlayerSettings.json file!");
        }
    }
}
