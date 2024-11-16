using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Update()
    {
        // ตัวอย่าง: กดปุ่ม Space เพื่อเปลี่ยน Scene
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SecondScene");
        }
    }
}
