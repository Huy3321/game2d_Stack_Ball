
using UnityEngine;
using UnityEngine.SceneManagement;
public class MENU : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChoiMoi()
    {
        SceneManager.LoadScene(1);


    }
    public void ThoatRaMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Thoat()
    {
        Application.Quit();
        
    }
}
