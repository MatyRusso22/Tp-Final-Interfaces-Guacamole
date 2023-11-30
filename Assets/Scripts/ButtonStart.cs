using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;


public class ButtonStart : MonoBehaviour
{
    bool gameStart;
    float counter;
    public DecrementUIText decrementUIText;
    // Start is called before the first frame update
    void Start()
    {
        gameStart = false;
        counter = 5;
    }

    

    // Update is called once per frame
    void Update()
    {
        if (gameStart)
        {
            counter -= Time.deltaTime;
            Debug.Log(counter);
            if (counter < 0)
            {
                gameStart = false;
                counter = 5;
            }
        }
    }

    public void Empezar()
    {
        Debug.Log("empezamos?????????");
        gameStart = true;
        decrementUIText.DecrementText();
    }
}


    /// <summary>
    /// Add this component to a GameObject and call the <see cref="DecrementText"/> method
    /// in response to a Unity Event to update a text display to count up with each event.
    /// </summary>
    public class DecrementUIText : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("The Text component this behavior uses to display the Decremented value.")]
        Text m_Text;

        /// <summary>
        /// The Text component this behavior uses to display the Decremented value.
        /// </summary>
        public Text text
        {
            get => m_Text;
            set => m_Text = value;
        }

        int m_Count;

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        protected void Awake()
        {
            if (m_Text == null)
                Debug.LogWarning("Missing required Text component reference. Use the Inspector window to assign which Text component to Decrement.", this);
        }

        /// <summary>
        /// Decrement the string message of the Text component.
        /// </summary>
        public void DecrementText()
        {
            m_Count -= 1;
            if (m_Text != null)
                m_Text.text = m_Count.ToString();
        }
    }

