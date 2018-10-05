using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Naming : MonoBehaviour {

	[ExecuteInEditMode]
	public class NamingProcess : MonoBehaviour
	{
		public string naming;
		void Awake()
		{
			name = naming;
		}
	}
}
