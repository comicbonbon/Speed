/*
 * Created by SharpDevelop.
 * User: owner
 * Date: 2014/09/02
 * Time: 1:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace Trump
{
	/// <summary>
	/// Description of Deck.
	/// </summary>
	
	public class Deck
	{
		protected List<Card> cards = new List<Card>();
		
		public Deck()
		{
			cards.Clear();
		}
		public Deck(Deck deck, int num)
		{
			putCard(deck, num);
		}
		
		public Card drawCard()
		{
			Card card = null;
			if(cards.Count != 0)
			{
				int id = UnityEngine.Random.Range(0, cards.Count - 1);
				card = cards[id];
				cards.RemoveAt(id);
			}
			return card;
		}
		
		// こうしておけば真ん中の置き場にも使えるんじゃね？
		public void putCard(Card card)
		{
			cards.Add(card);
		}
		// さらにこうしておけばMaster的なDeck作っておいてそこからプレイヤーに配る感じにできるんじゃね？
		public void putCard(Deck deck, int num)
		{
			for(var i = 0; i < num; i++)
			{
				Card card = deck.drawCard();
				if(card != null)	{cards.Add(card);}
				else				{break;}
			}
		}
		
		public override string ToString()
		{
			return string.Format("[Deck Cards={0}]", cards.Count);
		}
	}
}
