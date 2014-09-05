/*
 * Created by SharpDevelop.
 * User: owner
 * Date: 2014/09/02
 * Time: 0:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using UnityEngine;

namespace Trump
{
	/// <summary>
	/// Description of Card.
	/// </summary>
	
	public enum TrumpMark
	{
		SPADE = 1,
		CLUB,
		HART,
		DIA
	}
	
	public class Card
	{
		private int number = 0;
		public int Number
		{
			get {return number;}
		}
		private TrumpMark mark = 0;
		public TrumpMark Mark
		{
			get {return mark;}
		}
		
		public Card(TrumpMark m, int n)
		{
			number = n;
			mark = m;
		}
		
		public override string ToString()
		{
			return string.Format("[Card Number={0}, Mark={1}]", number, mark);
		}

	}
}
