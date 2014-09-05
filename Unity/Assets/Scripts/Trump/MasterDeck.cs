/*
 * Created by SharpDevelop.
 * User: owner
 * Date: 2014/09/03
 * Time: 1:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using UnityEngine;

namespace Trump
{
	/// <summary>
	/// Description of MasterDeck.
	/// </summary>
	
	// デッキ作成時にいじる用
	public class DeckOption
	{
		public int num = 1;
		
		public override string ToString()
		{
			return string.Format("[DeckOption Num={0}]", num);
		}

	}
	
	// 山札的扱い→ここからそれぞれに配るとか
	public class MasterDeck : Deck
	{
		public MasterDeck(/*DeckOption opt*/)
		{
			foreach(TrumpMark mark in Enum.GetValues(typeof(TrumpMark)))
			{
				for(int cardNum = 1; cardNum <= 13; cardNum++)
				{
					Card card = new Card(mark, cardNum);
					cards.Add(card);
					
					//Debug.Log(card.ToString());
				}
			}
		}
	}
}
