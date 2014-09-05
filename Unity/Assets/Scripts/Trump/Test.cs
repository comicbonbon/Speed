/*
 * Created by SharpDevelop.
 * User: owner
 * Date: 2014/09/03
 * Time: 1:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using UnityEngine;

namespace Trump
{
	/// <summary>
	/// Description of Test.
	/// </summary>
	
	public class Test : MonoBehaviour
	{
		private MasterDeck master;
		
		void Start()
		{
			master = new MasterDeck();
			Debug.Log(master.drawCard().ToString());
			Debug.Log(master.ToString());
			
			Deck myDeck = new Deck();
			myDeck.putCard(master, 10000);
			
			Debug.Log(master.ToString());
			Debug.Log(myDeck.ToString());
		}
	}
}
