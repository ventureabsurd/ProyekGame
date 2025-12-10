using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public TextMeshProUGUI coinText;

    private static CoinManager instance;

    private void Awake()
    {
        // --- SINGLETON (agar tidak dobel saat pindah scene) ---
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Subscribe ke event ketika scene selesai dimuat
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Cari ulang UI coinText di scene yang baru
        GameObject textObj = GameObject.Find("Text");

        if (textObj != null)
            coinText = textObj.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (coinText != null)
        {
            coinText.text = coinCount.ToString();
        }
    }
}
