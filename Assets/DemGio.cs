using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class DemGio : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI timeText;
    private float startTime;

    public TextMeshProUGUI thongBaoText;
    public float thoiGianDeKichHoatTinhNang;
    private bool tinhNangDaKichHoat = false;
    void Start()
    {
        startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        float thoiGianDaTroiQua;
        thoiGianDaTroiQua = Time.time - startTime;

        int minutes = ((int)thoiGianDaTroiQua / 60);
        int secords = ((int)thoiGianDaTroiQua % 60);
        timeText.text = string.Format("{0:00}:{1:00}",minutes,secords);
        if(thoiGianDaTroiQua >= thoiGianDeKichHoatTinhNang&&!tinhNangDaKichHoat)
        {
            tinhNangDaKichHoat = true;
            TinhNang();

        }
    }
    void TinhNang()
    {
        Debug.Log("Den gio roi");
        thongBaoText.text = "HẾT THỜI GIAN !!!";
        Time.timeScale = 0f;
    }
}
