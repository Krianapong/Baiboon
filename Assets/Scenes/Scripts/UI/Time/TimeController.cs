using UnityEngine;
using TMPro; // เพิ่มการอ้างอิงถึง TextMeshPro

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timeText; // เปลี่ยนเป็น TextMeshProUGUI
    private float gameTime = 480; // เริ่มเวลา (8:00 AM = 480 นาที)

    void Update()
    {
        gameTime += Time.deltaTime * 1; // เพิ่มเวลาในเกม (เร็วกว่าเวลาจริง)
        int hours = (int)(gameTime / 60) % 24;
        int minutes = (int)(gameTime % 60);
        timeText.text = $"{hours:00}:{minutes:00}"; // แสดงเวลาในรูปแบบ HH:MM
    }
}
