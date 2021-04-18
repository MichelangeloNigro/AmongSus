using UnityEngine;

namespace Riutilizzabile
{
	public abstract class AbstractGameEventListener : MonoBehaviour
	{
		[SerializeField] private GameEvent gameEvent;
		protected string name;
		
		private void OnEnable()
		{
			RegisterToEvent();
		}

		private void OnDisable()
		{
			UnregisterToEvent();
		}

		protected void RegisterToEvent()
		{
			gameEvent.RegisterListener(this);
		}

		protected void UnregisterToEvent()
		{
			gameEvent.UnregisterListener(this);
		}

		public void OnRaiseEvent()
		{
			OnEventRaised();
		}

		protected abstract void OnEventRaised();
	}
}