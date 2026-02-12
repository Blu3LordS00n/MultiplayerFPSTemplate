using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button _startServerButton;
    [SerializeField] private Button _startHostButton;
    [SerializeField] private Button _startClientButton;
    [SerializeField] private TextMeshProUGUI _playersInGameText;

    private void Awake()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        //_playersInGameText.text = $"Players in Game: {PlayerManager.Instance.GetPlayersInGame()}";
    }

    private void Start()
    {
        _startHostButton.onClick.AddListener(() => {
            if (NetworkManager.Singleton.StartHost())
            {
                Debug.Log("Host started successfully");
            }
            else{
                Debug.Log("Host failed to start");
            }
        });
        
        _startServerButton.onClick.AddListener(() => {
            if (NetworkManager.Singleton.StartServer())
            {
                Debug.Log("Server started successfully");
            }
            else{
                Debug.Log("Server failed to start");
            }
        });
        
        _startClientButton.onClick.AddListener(() => {
            if (NetworkManager.Singleton.StartClient())
            {
                Debug.Log("Client started successfully");
            }
            else{
                Debug.Log("Client failed to start");
            }
        });
    }
}
