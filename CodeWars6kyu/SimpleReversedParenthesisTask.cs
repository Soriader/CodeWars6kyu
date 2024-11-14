using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
	public class SimpleReversedParenthesisTask
	{
		public static int Solve(string s)
		{
			if (s.Length % 2 != 0)
			{
				return -1;
			}

			int openCount = 0;
			int closeCount = 0;

			foreach (char c in s)
			{
				if (c == '(')
				{
					openCount++;
				}
				else
				{
					if (openCount > 0)
					{
						openCount--;
					}
					else
					{
						closeCount++; 
					}
				}
			}

			return (openCount + 1) / 2 + (closeCount + 1) / 2;
		}


	}
}
//https://www.codewars.com/kata/5a3f2925b6cfd78fb0000040/train/csharp
//Twoje rozwiązanie w obecnej formie nie zadziała, ponieważ samo zliczanie otwierających ( i zamykających ) nawiasów nie wystarcza do określenia minimalnej liczby odwróceń potrzebnych do uzyskania zbalansowanego ciągu. 
//	Wynika to z faktu, że nawiasy muszą być odpowiednio ułożone, a nie tylko występować w równej liczbie.

//Główne problemy
//Kod zlicza całkowitą liczbę otwierających i zamykających nawiasów, ale nie uwzględnia, czy nawiasy są prawidłowo zbalansowane na poszczególnych pozycjach w ciągu.
//Nawet jeśli liczba otwierających i zamykających nawiasów jest taka sama, mogą być nieprawidłowo rozmieszczone. Na przykład, w ciągu ")()(", otwierających i zamykających jest tyle samo, ale są one źle rozmieszczone i trzeba by było wykonać odwrócenia, aby je zbalansować.
//Podejście, które rozwiąże problem
//Potrzebujemy podejścia, które bierze pod uwagę strukturę nawiasów w ciągu:

//Podczas iteracji przez ciąg śledź aktualny stan zbalansowania nawiasów.
//Licz, ile jest nadmiarowych otwierających lub zamykających nawiasów, które nie mają pary.
//Oto ogólny algorytm, który możesz spróbować:

//Przechodząc przez ciąg, utrzymuj licznik dla otwierających nawiasów, które nie zostały jeszcze sparowane.
//Jeśli natkniesz się na zamykający nawias bez otwierającego, zwiększ licznik dla wymaganych odwróceń.
//Na końcu suma niezamkniętych otwierających i nadmiarowych zamykających nawiasów da minimalną liczbę odwróceń.