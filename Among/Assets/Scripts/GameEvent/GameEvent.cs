using System.Collections.Generic;
using UnityEngine;

namespace Riutilizzabile
{
	[CreateAssetMenu(fileName = "AbstractGameEvent_", menuName = "Events/Abstract Game Event")]
	public class GameEvent : ScriptableObject
	{
		[SerializeField] private List<AbstractGameEventListener> listeners = new List<AbstractGameEventListener>();

		public void Raise()
		{
			foreach (var lis in listeners)
			{
				lis.OnRaiseEvent();
			}
		}

		public void RegisterListener(AbstractGameEventListener _listener)
		{
			if (!listeners.Contains(_listener))
				listeners.Add(_listener);
		}

		public void UnregisterListener(AbstractGameEventListener _listener)
		{
			if (listeners.Contains(_listener))
				listeners.Remove(_listener);
		}
	}
}