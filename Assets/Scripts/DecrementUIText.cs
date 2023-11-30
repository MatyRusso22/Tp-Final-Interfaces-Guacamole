using UnityEngine.UI;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
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
        protected void Awake2()
        {
            if (m_Text == null)
                Debug.LogWarning("Missing required Text component reference. Use the Inspector window to assign which Text component to Decrement.", this);
        }

        /// <summary>
        /// Decrement the string message of the Text component.
        /// </summary>
        public void DecrementText2()
        {
            m_Count -= 1;
            if (m_Text != null)
                m_Text.text = m_Count.ToString();
        }
    }
}
